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
            string[] scene = {
                "**********",
                "*P       *",
                "*        *",
                "*** * * **",
                "*        *",
                "*   M    *",
                "*        *",
                "*        *",
                "*       G*",
                "**********"
            };

            world = new World();

            for (int y = 0; y < scene.Length; y++)
            {
                for (int x = 0; x < scene[y].Length; x++)
                {
                    if (scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instantiate(wall);
                    }
                    else if (scene[y][x] == 'P')
                    {
                        Player player = new Player(x, y, scene[y][x]);
                        world.Instantiate(player);
                    }
                    else if (scene[y][x] == 'M')
                    {
                        Monster monster = new Monster(x, y, scene[y][x]);
                        world.Instantiate(monster);
                    }
                    else if (scene[y][x] == 'G')
                    {
                        Goal goal = new Goal(x, y, scene[y][x]);
                        world.Instantiate(goal);
                    }
                    else if (scene[y][x] == ' ')
                    {
                        Floor floor = new Floor(x, y, scene[y][x]);
                        world.Instantiate(floor);
                    }
                }
            }

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
            Console.Clear();
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
