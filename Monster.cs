using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Monster : CollideGameObject
    {
        public Monster() 
        {
        }

        public Monster(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        ~Monster()
        {
        }

        private int prevXMove = 0;
        private int prevYMove = 0;

        public override void Update()
        {
            prevXMove = 0;
            prevYMove = 0;

            Random random = new Random();
            int randomNumber = random.Next(0, 5); //0이면 정지 
            if (randomNumber == 1)
            {
                X++;
                prevXMove = 1;
            }
            else if (randomNumber == 2)
            {
                X--;
                prevXMove = -1;
            }
            else if (randomNumber == 3)
            {
                Y++;
                prevYMove = 1;
            }
            else if (randomNumber == 4)
            {
                Y--;
                prevYMove = -1;
            }
        }

        public override void Collide(CollideGameObject collideGameObject)
        {
            if (collideGameObject is Player)
            {
                return;
            }

            X -= prevXMove;
            Y -= prevYMove;
        }
    }
}
