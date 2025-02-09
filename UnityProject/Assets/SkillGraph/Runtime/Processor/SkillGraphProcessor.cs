﻿using System;
using System.Collections.Generic;
using System.Linq;
using GraphProcessor;
using UnityEngine;

namespace SkillGraph
{
    public class SkillGraphProcessor : BaseGraphProcessor
    {
        List< BaseNode >		processList;
        List< SkillStartNode >		startNodeList;

        Dictionary<BaseNode, List<BaseNode>>    nonConditionalDependenciesCache = new Dictionary<BaseNode, List<BaseNode>>();

        public bool             pause;

        public IEnumerator<BaseNode> currentGraphExecution { get; private set; } = null;

        // static readonly float   maxExecutionTimeMS = 100; // 100 ms max execution time to avoid infinite loops

        /// <summary>
        /// Manage graph scheduling and processing
        /// </summary>
        /// <param name="graph">Graph to be processed</param>
        public SkillGraphProcessor(BaseGraph graph) : base(graph) {}

        public override void UpdateComputeOrder()
        {
            // Gather start nodes:
            startNodeList = graph.nodes.Where(n => n is SkillStartNode).Select(n => n as SkillStartNode).ToList();

            // In case there is no start node, we process the graph like usual
            if (startNodeList.Count == 0)
            {
                Debug.LogError("No start node found in the graph");
            }
            else
            {
                nonConditionalDependenciesCache.Clear();
                // Prepare the cache of non-conditional node execution
            }
        }

        public override void Run()
        {
            IEnumerator<BaseNode> enumerator;

            Stack<BaseNode> nodeToExecute = new Stack<BaseNode>();
            // Add all the start nodes to the execution stack
            startNodeList.ForEach(s => nodeToExecute.Push(s));
            // Execute the whole graph:
            enumerator = RunTheGraph(nodeToExecute);
            
            
            while(enumerator.MoveNext());
        }
        

        IEnumerable<BaseNode> GatherNonConditionalDependencies(BaseNode node)
        {
            Stack<BaseNode> dependencies = new Stack<BaseNode>();

            dependencies.Push(node);
        
            while (dependencies.Count > 0)
            {
                var dependency = dependencies.Pop();

                foreach (var d in dependency.GetInputNodes().Where(n => !(n is ISkillFlowLinkNode)))
                    dependencies.Push(d);

                if (dependency != node)
                    yield return dependency;
            }
        }
        
        private IEnumerator<BaseNode> RunTheGraph()
        {
            int count = processList.Count;

            for(int i = 0; i < count; i++)
            {
                processList[i].OnProcess();
                yield return processList[i];
            }
        }
        
	    private IEnumerator<BaseNode> RunTheGraph(Stack<BaseNode> nodeToExecute)
		{
			HashSet<BaseNode> nodeDependenciesGathered = new HashSet<BaseNode>();
			HashSet<BaseNode> skipConditionalHandling  = new HashSet<BaseNode>();
	
			while(nodeToExecute.Count > 0)
			{
				var node = nodeToExecute.Pop();
				// TODO: maxExecutionTimeMS
	
				// In case the node is conditional, then we need to execute it's non-conditional dependencies first
				if(node is ISkillFlowLinkNode && !skipConditionalHandling.Contains(node))
				{
					// Gather non-conditional deps: TODO, move to the cache:
					if(nodeDependenciesGathered.Contains(node))
					{
						// Execute the conditional node:
						node.OnProcess();
						yield return node;
	
						// And select the next nodes to execute:
						switch(node)
						{
							case ISkillFlowLinkNode cNode:
								foreach(var n in cNode.GetExecutedNodes())
									nodeToExecute.Push(n);
								break;
							default:
								Debug.LogError($"Conditional node {node} not handled");
								break;
						}
	
						nodeDependenciesGathered.Remove(node);
					}
					else
					{
						nodeToExecute.Push(node);
						nodeDependenciesGathered.Add(node);
						foreach(var nonConditionalNode in GatherNonConditionalDependencies(node))
						{
							nodeToExecute.Push(nonConditionalNode);
						}
					}
				}
				else
				{
					node.OnProcess();
					yield return node;
				}
			}
		}

        // Advance the execution of the graph of one node, mostly for debug. Doesn't work for WaitableNode's executeAfter port.
        public void Step()
        {
            if (currentGraphExecution == null)
            {
	            Stack<BaseNode> nodeToExecute = new Stack<BaseNode>();
	            if(startNodeList.Count > 0)
		            startNodeList.ForEach(s => nodeToExecute.Push(s));

	            currentGraphExecution = startNodeList.Count == 0 ? RunTheGraph() : RunTheGraph(nodeToExecute);
	            currentGraphExecution.MoveNext(); // Advance to the first node
            }
            else
            if (!currentGraphExecution.MoveNext())
                currentGraphExecution = null;
        }
    }
}