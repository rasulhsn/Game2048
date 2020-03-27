namespace Game2048
{
    /// <summary>
    /// Game controller class.
    /// </summary>
    public abstract class BoardController
    {

        // null = 0 It means "EMPTY VALUE"
        private void UpShift()
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.GetLine(j, i) == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (this.GetLine(j, i) == 0)
                            {
                                int next = this.GetLine(j, i);
                                this.SetLine(j, i, this.GetLine(k, i));
                                this.SetLine(k, i, next);
                            }
                        }
                    }
                }
            }
        }
        public void Up()
        {
            UpShift();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.GetLine(j, i) != 0)
                    {
                        if ((j - 1) == -1) break;
                        else if (this.GetLine(j, i) == this.GetLine(j - 1, i))
                        {
                            this.SetLine(j, i, this.GetLine(j, i) + this.GetLine(j - 1, i));
                            this.SetLine(j - 1, i, 0);
                        }
                    }
                }
            }

            UpShift();
        }

        public void Down()
        {
            DownShift();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if(this.GetLine(j,i) != 0)
                    {
                        if ((j - 1) == -1) break;
                        else if (this.GetLine(j, i) == this.GetLine(j - 1, i))
                        {
                            this.SetLine(j, i, this.GetLine(j, i) + this.GetLine(j - 1, i));
                            this.SetLine(j - 1, i, 0);
                        }
                    }
                }
            }

            DownShift();
        }
        // null = 0 It means zero "EMPTY VALUE"
        private void DownShift()
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.GetLine(j, i) == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (this.GetLine(j, i) == 0)
                            {
                                int next = this.GetLine(j, i);
                                this.SetLine(j, i, this.GetLine(k, i));
                                this.SetLine(k, i, next);
                            }
                        }
                    }
                }
            }
        }

        // Using Left Collect Matris
        public void Left()
        {
            LeftShift();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.GetLine(i, j) != 0)
                    {
                        if (j == 3) break;
                        else if (this.GetLine(i, j) == this.GetLine(i, j + 1))
                        {
                            this.SetLine(i, j, this.GetLine(i, j) + this.GetLine(i, j + 1));
                            this.SetLine(i, j + 1, 0);
                        }
                    }
                }
            }

            LeftShift();
        }
        
        // null = 0 It means zero "EMPTY VALUE"
        private void LeftShift()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.GetLine(i, j) == 0)
                    {
                        for (int k = j + 1; k < 4; k++)
                        {
                            if (this.GetLine(i, j) == 0)
                            {
                                int next = this.GetLine(i, k);
                                this.SetLine(i, j, next);
                                this.SetLine(i, k, 0);
                            }
                        }
                    }
                }
            }
        }


        // Using Right Collect Matris
        public void Right()
        {
            RightShift();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >- 0; j--)
                {
                    if (this.GetLine(i, j) != 0)
                    {
                        if (j == 0) break;
                        else if (this.GetLine(i, j) == this.GetLine(i, j - 1))
                        {
                            this.SetLine(i, j, this.GetLine(i, j) + this.GetLine(i, j - 1));
                            this.SetLine(i, j - 1, 0);
                        }
                    }
                }
            }

            RightShift();
        }
        
        // null = 0 It means zero "EMPTY VALUE"
        private void RightShift()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (this.GetLine(i, j) == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (this.GetLine(i, j) == 0)
                            {
                                int next = this.GetLine(i, k);
                                this.SetLine(i, j, next);
                                this.SetLine(i, k, 0);
                            }
                        }
                    }
                }
            }
        }

        protected abstract int GetLine(int x, int y);
        protected abstract void SetLine(int x, int y, int value);      
    }
}
