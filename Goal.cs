using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Goal : CollideGameObject
    {
        public Goal()
        {
        }

        public Goal(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        ~Goal()
        {
        }
    }
}
