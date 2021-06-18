using UnityEngine;
namespace Chest
{
    public class ChestView : MonoBehaviour
    {
        private ChestController chestController;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void InitializeView(ChestController _chestController)
        {
            chestController = _chestController;
        }
    }
}