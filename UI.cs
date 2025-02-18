using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class UI : GameObject
    {
        public UI()
        { 
        }

        public UI(int x, int y, string text)
        {
            X = x;
            Y = y;
            Text = text;
            isOn = false;
        }

        ~UI() 
        { 
        }

        protected string Text;
        protected bool isOn = false;

        public void SetText(string text)
        {
            Text = text;
            isOn = true;
        }

        public override void Render()
        {
            if (isOn)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(Text);
            }
        }
    }
}
