using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public static class Game
    {
        //게임에 필요한 정보들

        // 게임에 필요한 기능들
        // 1. 게임시작


        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene cutScene;


        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Square", new SquareScene());
            sceneDic.Add("Town", new TitleScene());
            sceneDic.Add("Field", new TitleScene());
            sceneDic.Add("Castle", new TitleScene());
            sceneDic.Add("Guild", new TitleScene());
            cutScene = sceneDic["Title"];
            cutScene = sceneDic["Square"];
            cutScene = sceneDic["Town"];
            cutScene = sceneDic["Field"];
            cutScene = sceneDic["Castle"];
            cutScene = sceneDic["Guild"];



        }
        // 2. 게임 종료
        public static void End()
        {

        }
        // 3. 게임 동작
        public static void Run()
        {
            while (gameOver == false)
            {
                cutScene.Render(); // 출력
                cutScene.Choice(); // 선택지
                cutScene.Input(); // 입력
                cutScene.Update(); // 입력받은거 반영
                cutScene.Result(); // 입력받은 결과
                cutScene.Wait(); // 텍스트 초기화
                cutScene.Next(); // 다른 지역이동

            }
        }

        public static void Change(string sceneName)
        {
            cutScene = sceneDic[sceneName];
        }


    }

}
