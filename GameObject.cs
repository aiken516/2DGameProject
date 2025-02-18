using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class GameObject
    {
        public GameObject() 
        { 
        }

        ~GameObject()
        { 
        }

        public int X;
        public int Y;
        public char Shape;

        public virtual void Update()
        {

        }

        public virtual void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Shape);
        }
    }
}
