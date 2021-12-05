using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
    class TicTacToe1
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
