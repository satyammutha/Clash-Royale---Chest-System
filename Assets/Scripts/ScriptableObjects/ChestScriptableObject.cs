using Chest;
using System;
using UnityEngine;
namespace ChestSObj
{
    [CreateAssetMenu(fileName = "ChestScriptableObject", menuName = "ScriptableObjects/Chest/New ChestObject")]
    public class ChestScriptableObject : ScriptableObject
    {
        public ChestTypes chestTypes;
        public Time requiredTime;
        public float requiredGems;
        public int coins;
        public int gems;
        public ChestView chestView;

    }
    [CreateAssetMenu(fileName = "ChestScriptableObjectList", menuName = "ScriptableObjects/Chest/New ChestObjectList")]
    public class ChestScriptableObjectList : ScriptableObject
    {
        public ChestScriptableObject[] chestList;
    }
}