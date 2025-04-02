using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class SquareScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 모험가 길드로 간다. ");
            Console.WriteLine("2. 상점으로 간다. ");
            Console.WriteLine("3. 내성으로 간다. ");
            Console.WriteLine("4. 영지 밖으로 나간다. "); 
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                {
                    Game.Change("Guild");
                    Console.WriteLine(" 길드로 향합니다. ");

                    break;
                }

                case ConsoleKey.D2:
                    {
                        Game.Change("Shop");
                        Console.WriteLine(" 상점으로 향합니다. ");

                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Game.Change("Castle");
                        Console.WriteLine(" 내성으로 향합니다. ");

                        break;
                    }

                case ConsoleKey.D4:
                    {
                        Game.Change("Field");
                        Console.WriteLine(" 밖으로 향합니다. ");

                        break;
                    }
            }

        }

        public override void Render()
        {
            Console.WriteLine("모험가가 되기 위해 영지의 광장으로 왔다. ");
            Console.WriteLine(" 광장은 사람들로 북적이고 있다. ");
            Console.WriteLine(" 어디로 가야할까 ");
        }

        public override void Result()
        {
            
        }

        public override void Update()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Wait()
        {
            Console.Clear();
        }
    }
}
