using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_2048.Classes
{
    public sealed class Game_2048
    {
        // Property Board...
        private int[,] Matris_Board;
        // Not used..
        //private List<bool> Action_Boards;


        // Constructor..
        public Game_2048()
        {
            this.Matris_Board = null;
            this.Action_Boards = new List<bool>();
        }
        
        public Game_2048(int[,] Board)
        {
            if (Board.Length == 16)
                this.Matris_Board = Board;
            else
                this.Matris_Board = null;

            this.Action_Boards = new List<bool>();
        }


        public void DownKey()
        {
            
            DownNullControl();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if(this.Matris_Board[j,i] != 0)
                    {
                        if ((j - 1) == -1) break;
                        else if (this.Matris_Board[j, i] == this.Matris_Board[j - 1, i])
                        {
                            this.Matris_Board[j, i] += this.Matris_Board[j - 1, i];
                            this.Matris_Board[j - 1, i] = 0;
                        }
                    }
                }
            }

            DownNullControl();
        }
        // null = 0 It means zero "EMPTY VALUE"
        private void DownNullControl()
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.Matris_Board[j, i] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (this.Matris_Board[j, i] == 0)
                            {
                                int next = this.Matris_Board[j, i];
                                this.Matris_Board[j, i] = this.Matris_Board[k, i];
                                this.Matris_Board[k, i] = next;
                            }
                        }
                    }
                }
            }
        }

        // Using Left Collect Matris
        public void LeftKey_v2()
        {
            LeftNullControl();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.Matris_Board[i, j] != 0)
                    {
                        if (j == 3) break;
                        else if (this.Matris_Board[i, j] == this.Matris_Board[i, j + 1])
                        {
                            this.Matris_Board[i, j] += this.Matris_Board[i, j + 1];
                            this.Matris_Board[i, j + 1] = 0;
                        }
                    }
                }
            }

            LeftNullControl();
        }
        private void LeftKey()
        {
            LeftNullControl();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.Matris_Board[i, j] != 0)
                    {
                        if (j == 0) break;
                        else if (this.Matris_Board[i, j] == this.Matris_Board[i, j - 1])
                        {
                            this.Matris_Board[i, j - 1] += this.Matris_Board[i, j];
                            this.Matris_Board[i, j] = 0;
                        }
                    }
                }
            }

            LeftNullControl();
        }
        // null = 0 It means zero "EMPTY VALUE"
        private void LeftNullControl()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.Matris_Board[i, j] == 0)
                    {
                        for (int k = j + 1; k < 4; k++)
                        {
                            if (this.Matris_Board[i, j] == 0)
                            {
                                int next = this.Matris_Board[i, k];
                                this.Matris_Board[i, j] = next;
                                this.Matris_Board[i, k] = 0;
                            }
                        }
                    }
                }
            }
        }


        // Using Right Collect Matris
        public void RightKey_v2()
        {
            RightNullControl();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >- 0; j--)
                {
                    if (this.Matris_Board[i, j] != 0)
                    {
                        if (j == 0) break;
                        else if (this.Matris_Board[i, j] == this.Matris_Board[i, j - 1])
                        {
                            this.Matris_Board[i, j] += this.Matris_Board[i, j - 1];
                            this.Matris_Board[i, j-1] = 0;
                        }
                    }
                }
            }

            RightNullControl();
        }
        private void RightKey()
        {
            RightNullControl();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.Matris_Board[i, j] != 0)
                    {
                        if (j == 3) break;
                        else if (this.Matris_Board[i, j] == this.Matris_Board[i, j + 1])
                        {
                            this.Matris_Board[i, j + 1] += this.Matris_Board[i, j];
                            this.Matris_Board[i, j] = 0;
                        }
                    }
                }
            }

            RightNullControl();
        }
        // null = 0 It means zero "EMPTY VALUE"
        private void RightNullControl()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.Matris_Board[i, j] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (this.Matris_Board[i, j] == 0)
                            {
                                int next = this.Matris_Board[i, k];
                                this.Matris_Board[i, j] = next;
                                this.Matris_Board[i, k] = 0;
                            }
                        }
                    }
                }
            }
        }


        // Temporary..
        public void Show_Matris()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(this.Matris_Board[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

    }
}
