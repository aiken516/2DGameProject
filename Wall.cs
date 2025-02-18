using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Wall : CollideGameObject
    {
        public Wall()
        { 
        }

        public Wall(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        ~Wall() 
        {
        }
    }
}
