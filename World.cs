using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class World
    {
        public World() 
        {
        }

        ~World()
        {
        }

        public GameObject[] gameObjects = new GameObject[100];
        private int useGameObject = 0;

        public void Instantiate(GameObject gameObject)
        {
            gameObjects[useGameObject] = gameObject;
            useGameObject++;
        }

        public void Update()
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Update();
            }

            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (gameObjects[i] is CollideGameObject collide)
                {
                    collide.CollideCheck(this);
                }
            }
        }

        public void Render()
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
