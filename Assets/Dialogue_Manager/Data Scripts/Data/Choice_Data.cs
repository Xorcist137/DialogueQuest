using System;
using UnityEngine;
using DialogueQuest;
using DialogueQuest.scriptable_object;

namespace DialogueQuest.Data
{
    [Serializable]
    public class Choice_Data
    {
        [field:SerializeField] public string Choice_Text { get; set; }
        [field:SerializeField] public Basic_Nodes Next_Saved_Node { get; set; } 
    }
}