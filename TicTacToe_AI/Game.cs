using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_AI
{
    static class Game
    {

        static byte[,] grid = new byte[3, 3];
        const char player1 = 'X';
        const char player2 = 'O';
        static int turn = 0;

        public static bool CheckPosition(byte position)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) == position)
                    {
                        if(grid[i, j] != 0)
                        {
                            return false;
                        }
                        else
                        {
                            grid[i, j] = MarkPosition();
                        }
                    }
                }
            }
            return true;
        }

        public static char MarkPosition(byte position)
        {
            char p;
            if (!CheckPosition(position))
            { }
            if (turn % 2 == 0)
            {
                p = player1;
            }
            else
            {
                p = player2;
            }
            SwitchTurns();

            return p;

        }
        

        public static void SwitchTurns()
        {
            turn++;
        }
    }

    

    class AI
    {
    }
}
