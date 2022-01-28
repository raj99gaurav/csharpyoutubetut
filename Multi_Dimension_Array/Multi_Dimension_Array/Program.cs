//C# program to implement Multi Dimension Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dimension_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create 2D 4r and 2 col.
            int[,] intA = new int[4, 2];

            //3D 4,2,3

            int[,,] intB = new int[4, 2, 3]; */

            //2d array
            int[,] intA = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //sane array using dim 4r and 2 c
            int[,] intA_d = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //string

            string[,] str = new string[4, 2] { { "one", "two" }, { "rg", "vlogs" }, { "youtube", "like" }, { "share", "learn" } };

            //3d array

            int[,,] intB = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            //3d array dim

            int[,,] intB_d = new int[2,2,3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            //Task 1 : 2D,3D,4D

            //Accessing array ele.

            Console.WriteLine("2D array [0][0] : " + intA[0,0]);

            Console.WriteLine("2D array [1][0] Dim : " + intA_d[1, 0]);

            Console.WriteLine("3D array [1][0][1] : " + intB[1, 0 ,1]);

            Console.WriteLine("3D array [0][1][1] : " + intB_d[0, 1, 1]);


            //loop string

            Console.WriteLine("String elements : ");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(str[i, j] + " ");

            //Task 2 : Can we make strings without dim.
            //Task 3 : Can you use different loops in muli dim arrays

            Console.ReadLine();

        }
    }
}
