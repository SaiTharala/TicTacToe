using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe Game:");
            TicTacToe1 play = new TicTacToe1();
            play.CreateBoard();

        }
    }
}
