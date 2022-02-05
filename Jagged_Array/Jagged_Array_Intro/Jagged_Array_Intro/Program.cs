//Declaration and initialization of jagged arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Intro
{
    class Program
    {
        void comment(string[] args)
        {
            /*
            //syntax
            dataype[][] name_of_array = new datatype[rows][];
            int[][] j_array = new int[4][];

            //initialization : must be done before use

            //method 1: providing size of each array separatey 
            j_array[0] = new int[2]; // array of 2 int
            j_array[1] = new int[4]; // array of 4 int
            j_array[2] = new int[6]; // array of 6 int
            j_array[3] = new int[7]; // array of 7 int

            //method 2: we wont give the size but elements directly

            j_array[0] = new int[] { 1,2,3}; 
            j_array[1] = new int[] { 11, 32, 99, 45, 65, 465 }; 
            j_array[2] = new int[] { 34, 56, 76, 45, 65 }; 
            j_array[3] = new int[] { 23, 43, 56, 34 };


            //Declaration as well as initalization

            //method 1 : Direct Method

            int[][] j_array = new int[][]{
                new int[] { 1,2,3}, 
                new int[] {23,34,56,67 },
                new int[]{23,34,45,34,234,643,345,56}
            };

            //method 2 : short hand method
            int[][] j_array = {
                new int[] { 1,2,3},
                new int[] {23,34,56,67 },
                new int[] {23,34,45,34,234,643,345,56}
            };

            j_array[1][2] = 99; 
            */

        }

        static void Main(string[] args)
        {
            //declare 
            int[][] j_array = new int[4][];

            //initalize

            j_array[0] = new int[] { 1, 2, 3, 4 };
            j_array[1] = new int[] { 11, 34, 67 };
            j_array[2] = new int[] { 19 , 23 };
            j_array[3] = new int[] { 0, 45, 78 , 53 , 99 };

            //display

            for(int n=0 ; n < j_array.Length ; n++)
            {
                //Print row no.

                System.Console.Write("Row ( {0} ) : ", n);

                for(int k=0 ; k < j_array[n].Length ; k++)
                {
                    //Print elements
                    System.Console.Write(" {0} ", j_array[n][k]);
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
