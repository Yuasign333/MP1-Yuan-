using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1_Yuan_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring  important variables used for this code

            Random randomizer = new Random(); // for randomizing numbers 

            bool isDuplicate; // bool flag for checking If there are any Duplicated Numbers ( we want all numbers appear are UNIQUE Numbers ) 

            int generatedNumber; // use later for storing the random number generator



            int[][] BingoOuterArray = new int[5][]; // jagged array with the size of 5 for outer array


            // Initialize each column as an array with 5 rows
            for (int row = 0; row < BingoOuterArray.Length; row++)
            {
                BingoOuterArray[row] = new int[5]; // for Bingo Inner Array
            }

            // for checking if all numbers are unique or not
            for (int row = 0; row < BingoOuterArray.Length; row++)
            {
                for (int column = 0; column < BingoOuterArray[row].Length; column++)
                {
                    do 
                    {
                        isDuplicate = false;               // mininum         // maximum
                        generatedNumber = randomizer.Next((column * 15) + 1, (column * 15) + 16);  // B (1-15), I (16-30), N (31-45), G (46-60), O (61-75)
                                                                                                   // Generate a random number based on the column range:

                        // Check for duplicates in the same column
                        for (int c = 0; c < row; c++) 
                        {
                            if (BingoOuterArray[c][column] == generatedNumber)
                            {
                                isDuplicate = true; // go to while loop
                                break;
                            }
                        }

                    } 
                    while (isDuplicate);
                    {
                        // if it is duplicate, It will loop back until all numbers are UNIQUE
                    }

                    BingoOuterArray[row][column] = generatedNumber; // Now stores only unique numbers
                }
            }

            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White; // filling up the bingo card with white background
            Console.WriteLine(" B   | I   | N   | G   | O   |"); // header 
            Console.WriteLine("+----+----+----+----+----+----");

            // Print the bingo numbers with borders
            for (int row = 0; row < BingoOuterArray.Length; row++)
            {
                for (int column = 0; column < BingoOuterArray[row].Length; column++)
                {
                    Console.ForegroundColor = ConsoleColor.Black; 
                    Console.Write($" {BingoOuterArray[row][column],3} |"); // Space before numbers for alignment
                }
                Console.WriteLine(); // Move to the next row

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("+----+----+----+----+----+----");
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            

            // The End!
        }
    }
}
