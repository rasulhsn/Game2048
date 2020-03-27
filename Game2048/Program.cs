using System;

namespace Game2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MassiveMatris =
            {
                {4,0,2,2 },
                {0,0,0,2 },
                {4,4,8,0},
                {0,0,0,0 }
            };
            int[,] MassiveMatris2 =
            {
                {4,0,0,2 },
                {0,0,0,2 },
                {4,0,8,0},
                {0,0,0,0 }
            };


            ConsoleBoard gameConsole = new ConsoleBoard(MassiveMatris);



            gameConsole.Show();
            gameConsole.Down();
            Console.WriteLine();

            gameConsole.Show();
            //Console.WriteLine();
            //gameConsole.Left();
            //gameConsole.Show();

            /* Testing All variants
            GM.Show_Matris();
            Console.WriteLine();
            GM.LeftKey_v2();
            Console.WriteLine();
            GM.Show_Matris();
            Console.WriteLine();
            GM.LeftKey_v2();
            Console.WriteLine();
            GM.Show_Matris();

            // GM Left P
            GM.Show_Matris();
            Console.WriteLine();
            GM.LeftKey();
            GM.Show_Matris();
            Console.WriteLine();
            // GM2 Left_v2
            GM2.Show_Matris();
            Console.WriteLine();
            GM2.LeftKey_v2();
            GM2.Show_Matris();
            */

            /*
            GM.Show_Matris();
            Console.WriteLine();

            GM.LeftKey();
            Console.WriteLine();

            GM.Show_Matris();
            Console.WriteLine();

            GM.RightKey();
            Console.WriteLine();

            GM.Show_Matris();
            */

            Console.ReadKey();
        }
    }
}
