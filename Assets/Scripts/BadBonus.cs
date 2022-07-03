using UnityEngine;

namespace Maze
{


    public class BadBonus : Bonus, IFly, IRotation
    {
        private float hightFly;
        private float speedRotation;

        private void Awake()
        {
            hightFly = Random.Range(1f, 5f);
            speedRotation = Random.Range(13f, 40f);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, hightFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }
        void Update ()
        {
            Fly();
            Rotate();
        }
    }
}
