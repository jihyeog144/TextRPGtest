using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class TitleScene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("------------------------");

            Console.WriteLine("-                      -");

            Console.WriteLine("-       중세 RPG       -");

            Console.WriteLine("-                      -");

            Console.WriteLine("------------------------");

            Console.WriteLine("");

        }

        public override void Choice()
        {
            Console.WriteLine("1. 새로 시작하기 ");

            Console.WriteLine("2. 불러오기 ");

            Console.WriteLine("3. 종료하기 ");
        }

        public override void Result()
        {
           
        }

        public override void Update()
        {
            input = Console.ReadKey(true).Key;
        }


        public override void Next()
        {

            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Change("Square");
                    break;

                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;


            }
        }


        public override void Wait()
        {
            Console.Clear();
        }
    }
}
