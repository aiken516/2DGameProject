using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Floor : GameObject
    {
        public Floor() 
        {
        }

        public Floor(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        ~Floor()
        {
        }

        public override void Render()
        {
        }
    }
}
