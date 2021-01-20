using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wrd = new string[] { "fine", "none", "no" };
            string w = "qwertyuiopasdfghjklzxcvbnm";
            IsAlienSorted isAlienSorted = new IsAlienSorted();
            isAlienSorted.IsAlien(wrd, w);
            return;

            List<int> l1 = new List<int> { 15, 2, 48, 19, 28, 22, 44, 2, 32, 46, 46, 24, 1, 23, 49, 26, 23, 17, 17, 46, 4, 30, 40, 36, 20, 5 };
            l1 = new List<int> { 5, 10, 20, 100, 105 };
            SubArrayWithGivenSum sa = new SubArrayWithGivenSum();
            sa.solve(l1, 110);


            List<string> ls = new List<string>{ "53..7....", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79" };
            ValidSudoku sudoku = new ValidSudoku();
            sudoku.ProcessSudoku(ls);

            char[,] sudoko = {
                    { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    {'.','9','8','.','.','.','.','6','.'},
                    {'8','.','.','.','6','.','.','.','3'},
                    {'4','.','.','8','.','3','.','.','1'},
                    {'7','.','.','.','2','.','.','.','6'},
                    {'.','6','.','.','.','.','2','8','.'},
                    {'.','.','.','4','1','9','.','.','5'},
                    {'.','.','.','.','8','.','.','7','9'} };

            ValidSudoku vs = new ValidSudoku();
            vs.IsValidSudoku(sudoko);

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
