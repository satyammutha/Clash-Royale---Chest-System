using UnityEngine;
namespace Chest
{
    public class ChestController
    {
        public ChestController(ChestModel _chestModel, ChestView _chestView)
        {
            chestModel = _chestModel;
            chestView = GameObject.Instantiate<ChestView>(_chestView);
            chestView.InitializeView(this);
        }

        public ChestModel chestModel { get; private set; }
        public ChestView chestView { get; private set; }
    }
}