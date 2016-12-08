using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_2048.Classes;


namespace Game_2048
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MassiveMatris =
            {
                {4,0,2,2 },
                {0,0,0,2 },
                {4,0,8,0},
                {0,0,0,0 }
            };
            int[,] MassiveMatris2 =
            {
                {4,0,0,2 },
                {0,0,0,2 },
                {4,0,8,0},
                {0,0,0,0 }
            };


            Game_2048.Classes.Game_2048 GM = new Classes.Game_2048(MassiveMatris);
            //Game_2048.Classes.Game_2048 GM2 = new Classes.Game_2048(MassiveMatris2);


            GM.Show_Matris();
            GM.DownKey();
            Console.WriteLine();

            GM.Show_Matris();
            Console.WriteLine();
            GM.LeftKey_v2();
            GM.Show_Matris();

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

            //LeftNullControl(MassiveMatris);
            //RightNullControl(MassiveMatris);

            Console.ReadKey();
        }
       
        public static void Show_Matris(int[,] Show)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Show[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        public static void DownNullControl(int[,] UpControl)
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if(UpControl[j,i] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if(UpControl[j,i] == 0)
                            {
                                int next = UpControl[j, i];
                                UpControl[j, i] = UpControl[k, i];
                                UpControl[k, i] = next;
                            }
                        }
                    }
                }
            }
        }

        // First Logic Null Right
        public static void RightNullControl(int[,] RightControl)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (RightControl[i, j] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (RightControl[i, j] == 0)
                            {
                                int next = RightControl[i, k];
                                RightControl[i, j] = next;
                                RightControl[i, k] = 0;
                            }
                        }
                    }
                }
            } 
        }

        // First Logic Null Left
        public static void LeftNullControl(int[,] LeftControl)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (LeftControl[i, j] == 0)
                    {
                        for (int k = j + 1; k < 4; k++)
                        {
                            if (LeftControl[i, j] == 0)
                            {
                                int next = LeftControl[i, k];
                                LeftControl[i, j] = next;
                                LeftControl[i, k] = 0;
                            }
                        }
                    }
                }
            }
        }


    }
}
