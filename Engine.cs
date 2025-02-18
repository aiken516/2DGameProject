using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameProject
{
    public class Engine
    {
        private static Engine instance;

        public static Engine Instance 
        { 
            get 
            {
                if (instance == null)
                { 
                    instance = new Engine();
                }

                return instance; 
            } 
        }

        public Engine()
        {

        }

        ~Engine()
        {

        }

        private bool isRunning = false;
        private World world;

        public void Load()
        {
            world = new World();
            world.Load();

            isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                ProcessInput();
                Update();
                Render();
            }
        }

        private void Render()
        {
            world.Render();
        }

        private void Update()
        {
            world.Update();
        }

        private void ProcessInput()
        {
            Input.Process();
        }
    }
}
