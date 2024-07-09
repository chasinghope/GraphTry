using GraphProcessor;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace SkillGraph.Editor
{
    public class SkillGraphAssetCallbacks
    {
        [MenuItem("Assets/Create/SkillGraph", false, 9)]
        public static void CreateGraphPorcessor()
        {
            var graph = ScriptableObject.CreateInstance< SkillGraph >();
            ProjectWindowUtil.CreateAsset(graph, "SkillGraph.asset");
        }

        [OnOpenAsset(0)]
        public static bool OnBaseGraphOpened(int instanceID, int line)
        {
            var asset = EditorUtility.InstanceIDToObject(instanceID) as SkillGraph;

            // if (asset != null && AssetDatabase.GetAssetPath(asset).Contains("Examples"))
            if(asset != null)
            {
                EditorWindow.GetWindow<SkillGraphWindow>().InitializeGraph(asset as BaseGraph);
                return true;
            }
            return false;
        }
    }

}