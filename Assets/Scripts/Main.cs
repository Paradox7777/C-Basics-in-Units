using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        [SerializeField]
        private Unit _player;
        
        public InputController _inputController;
        private void Awake()
        {
            _inputController = new InputController(_player);
        }

        void Update()
        {
            _inputController.Update();
        }
    }
}
