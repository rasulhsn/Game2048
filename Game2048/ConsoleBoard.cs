using System;

namespace Game2048
{
    public class ConsoleBoard : BoardController
    {
        // Property Board...
        private int[,] _boardLine;

        public ConsoleBoard(int[,] board)
        {
            if (board != null && board.Length == 16)
                this._boardLine = board;
            else
                throw new Exception();
        }


        public void Show()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(this._boardLine[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        protected override int GetLine(int x, int y)
        {
            return _boardLine[x, y];
        }

        protected override void SetLine(int x, int y,int value)
        {
            this._boardLine[x, y] = value;
        }
    }
}
