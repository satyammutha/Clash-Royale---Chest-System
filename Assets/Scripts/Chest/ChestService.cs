using UnityEngine;
using Chest;
using ChestSObj;
using UnityEngine.UI;

public class ChestService : MonoBehaviour
{
    [SerializeField] private Button randomButton;
    [SerializeField] private ChestScriptableObjectList objectList;
    [SerializeField] private GameObject canvasGameObject;
    private ChestScriptableObject chest;
    private ChestModel chestModel;
    private void Awake()
    {
        randomButton.onClick.AddListener(CreateNewChest);
    }

    private void CreateNewChest()
    {
        for(int i=0; i<1; i++)
        {
            NewChest();
        }
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
