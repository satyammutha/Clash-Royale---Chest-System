using UnityEngine;
using ChestSObj;
namespace Chest
{
    public class ChestModel
    {
        public ChestModel(ChestScriptableObject chestScriptableObject)
        {
            chestTypes = chestScriptableObject.chestTypes;
            requiredTimer = chestScriptableObject.requiredTime;
            requiredGems = chestScriptableObject.requiredGems;
            coins = chestScriptableObject.coins;
            gems = chestScriptableObject.gems;
        }

        public ChestTypes chestTypes { get; private set; }
        public Time requiredTimer { get; private set; }
        public float requiredGems { get; private set; }
        public int coins { get; private set; }
        public int gems { get; private set; }
    }
}