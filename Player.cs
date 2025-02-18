using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Player : CollideGameObject
    {
        public Player() 
        {
        }

        public Player(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        ~Player() 
        {
        }

        private int prevXMove = 0;
        private int prevYMove = 0;

        public override void Update()
        {
            prevXMove = 0;
            prevYMove = 0;

            if (Input.GetKeyDown(ConsoleKey.W) || Input.GetKeyDown(ConsoleKey.UpArrow))
            {
                Y--;
                prevYMove = -1;
            }
            if (Input.GetKeyDown(ConsoleKey.S) || Input.GetKeyDown(ConsoleKey.DownArrow))
            {
                Y++;
                prevYMove = 1;
            }
            if (Input.GetKeyDown(ConsoleKey.A) || Input.GetKeyDown(ConsoleKey.LeftArrow))
            {
                X--;
                prevXMove = -1;
            }
            if (Input.GetKeyDown(ConsoleKey.D) || Input.GetKeyDown(ConsoleKey.RightArrow))
            {
                X++;
                prevXMove = 1;
            }
        }

        public override void Collide(CollideGameObject collideGameObject)
        {
            X -= prevXMove;
            Y -= prevYMove;
        }
    }
}
