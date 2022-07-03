using UnityEngine;

namespace Maze
{


    public class GoodBonus : Bonus, IFly, IFlick
    {
        private float hightFly;
        private Material material;

        private void Awake()
        {
            hightFly = Random.Range(1f, 5f);
            material = GetComponent<Renderer>().material;
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, hightFly), transform.position.z);
        }

        public void Flick()
        {
            material.color = new Color(material.color.r, material.color.g, material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
        void Update()
        {
            Fly();
            Flick();
        }
    }
}