using DialogueQuest.Enumerations;
using UnityEngine;
using DialogueQuest.Utilities;
using UnityEngine.UIElements;

namespace DialogueQuest.Elements
{
    public class Choice_Node :Basic_Node
    {
        Node_Types node_type = Node_Types.Choice_Node;
        public override void Initialize(Vector2 position)
        {
            base.Initialize(position);
        }

        public override void draw()
        {
            base.draw();
        }

        private void Create_Choice_Port()
        {
            //For creating choides and removing 
        }
    }
}