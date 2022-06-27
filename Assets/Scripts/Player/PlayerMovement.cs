using UnityEngine;

namespace Maze
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        public float speed;

        void Update()
        {
            GetInput();
        }

        private void GetInput()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.localPosition += -transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.localPosition += -transform.right * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.localPosition += transform.right * speed * Time.deltaTime;
            }
        }
    }

}