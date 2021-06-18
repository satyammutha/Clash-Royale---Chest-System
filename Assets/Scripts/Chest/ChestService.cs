using UnityEngine;
using Chest;
using ChestSObj;
using UnityEngine.UI;

public class ChestService : MonoBehaviour
{
    [SerializeField] private Button randomButton;
    [SerializeField] private ChestScriptableObjectList objectList;
    private ChestScriptableObject chest;
    private ChestModel chestModel;
    private void Update()
    {
        randomButton.onClick.AddListener(CreateNewChest);
    }

    private void CreateNewChest()
    {
        NewChest();
    }

    public ChestController NewChest()
    {
        int random = Random.Range(0, objectList.chestList.Length);
        chest = objectList.chestList[random];
        ChestModel _chestModel = new ChestModel(chest);
        chestModel = _chestModel;
        ChestController chestController = new ChestController(chestModel, chest.chestView);
        return chestController;
    }
}
