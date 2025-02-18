using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2DGameProject
{
    public class World
    {
        private static World instance;

        public static World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }

                return instance;
            }
        }

        public World() 
        {
            instance = this;
        }

        ~World()
        {
        }

        public GameObject[] gameObjects = new GameObject[100];
        public UI[] UIs = new UI[10];
        private int useGameObject = 0;
        private int useUI = 0;

        private bool isGameEnd = false;

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

            for (int y = 0; y < scene.Length; y++)
            {
                for (int x = 0; x < scene[y].Length; x++)
                {
                    if (scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        Instantiate(wall);
                    }
                    else if (scene[y][x] == 'P')
                    {
                        Player player = new Player(x, y, scene[y][x]);
                        Instantiate(player);
                    }
                    else if (scene[y][x] == 'M')
                    {
                        Monster monster = new Monster(x, y, scene[y][x]);
                        Instantiate(monster);
                    }
                    else if (scene[y][x] == 'G')
                    {
                        Goal goal = new Goal(x, y, scene[y][x]);
                        Instantiate(goal);
                    }
                    else if (scene[y][x] == ' ')
                    {
                        Floor floor = new Floor(x, y, scene[y][x]);
                        Instantiate(floor);
                    }
                }
            }


            for (int i = 0; i < UIs.Length; i++)
            {
                UI ui = new UI(0, 10 + i, "");
                Instantiate(ui);
            }
        }

        public void Clear()
        {
            gameObjects = new GameObject[100];
            UIs = new UI[10];
            useGameObject = 0;
            useUI = 0;
            isGameEnd = false;
            Console.Clear();
        }

        public void Instantiate(GameObject gameObject)
        {
            gameObjects[useGameObject] = gameObject;
            useGameObject++;
        }

        public void Instantiate(UI ui)
        {
            UIs[useUI] = ui;
            useUI++;
        }

        public void Update()
        {
            if (isGameEnd)
            {
                Clear();
                Load();
            }

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Update();
            }

            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (gameObjects[i] is CollideGameObject collide)
                {
                    collide.CollideCheck(this);
                }
            }
        }

        public void Render()
        {
            Console.Clear();

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Render();
            }

            for (int i = 0; i < UIs.Length; i++)
            {
                UIs[i].Render();
            }
        }

        public void GameOver()
        {
            isGameEnd = true;
            UIs[0].SetText("Game Over");
        }

        public void GameClear()
        {
            isGameEnd = true;
            UIs[0].SetText("Game Clear");
        }
    }
}
