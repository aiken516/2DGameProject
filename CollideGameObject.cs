using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class CollideGameObject : GameObject
    {
        public CollideGameObject() 
        {
        }

        ~CollideGameObject()
        { 
        }

        public virtual void CollideCheck(World world)
        {
            for (int i = 0; i < world.gameObjects.Length; i++)
            {
                if (world.gameObjects[i] != this && world.gameObjects[i] is CollideGameObject collideGameObject)
                {
                    if (collideGameObject.X == this.X && collideGameObject.Y == this.Y)
                    {
                        Collide(collideGameObject);
                    }
                }
            }
        }

        public virtual void Collide(CollideGameObject collideGameObject)
        {
        }
    }
}
