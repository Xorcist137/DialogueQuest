using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Dialogue_Quest.Window
{
    public class Editor_Window: EditorWindow
    {
        [MenuItem("Window/Dialogue_Quest")]    
        public static void ShowExample()
        {
            Editor_Window window = GetWindow<Editor_Window>("Dialogue_Quest_Editor_Window");
        }

        private void OnEnable()
        {
            ADD_GraphView();
        }

        private void ADD_GraphView()
        {
            Graph_View graph = new Graph_View();
            graph.StretchToParentSize();
            rootVisualElement.Add(graph);
        }
        
    }
}

