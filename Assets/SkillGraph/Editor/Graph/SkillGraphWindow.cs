using GraphProcessor;
using UnityEditor;
using UnityEngine;
using GraphProcessor;
using SkillGraph;

namespace SkillGraph.Editor
{
    public class SkillGraphWindow : BaseGraphWindow
    {
        SkillGraph graph;

        [MenuItem("Skill/Skill Graph")]
        public static SkillGraphWindow OpenGraph()
        {
            var window = GetWindow<SkillGraphWindow>();
            window.graph = ScriptableObject.CreateInstance<SkillGraph>();
            window.InitializeGraph(window.graph);
            window.Show();
            return window;
        }


        protected override void OnDestroy()
        {
            graphView?.Dispose();
            DestroyImmediate(graph);
        }
        

        protected override void InitializeWindow(BaseGraph graph)
        {
            titleContent = new GUIContent("Skill Graph");
            if (graphView == null)
                graphView = new BaseGraphView(this);
            rootView.Add(graphView);
        }
    }
}