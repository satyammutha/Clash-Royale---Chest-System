using Chest;
using UnityEngine;
namespace ChestSObj
{
    [CreateAssetMenu(fileName = "ChestScriptableObjectList", menuName = "ScriptableObjects/Chest/New ChestObjectList")]
    public class ChestScriptableObjectList : ScriptableObject
    {
        public ChestScriptableObject[] chestList;
    }
}