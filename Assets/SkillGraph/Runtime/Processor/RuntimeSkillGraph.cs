using System;
using Unity.VisualScripting;
using UnityEngine;

namespace SkillGraph
{
    public class RuntimeSkillGraph : MonoBehaviour
    {
        public SkillGraph graph;
        public SkillGraphProcessor processor;

        private void Start()
        {
            processor = new SkillGraphProcessor(graph);
        }

        private void Update()
        {
            if (processor != null && Input.GetKeyDown(KeyCode.Space))
            {
                processor.Run();
            }
        }
    }
}