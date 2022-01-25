//Accessing Array using different loops

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingArrayLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intA; //declare

            intA = new int[5]; //alocation

            //initalization

            intA[0] = 10; // index of array starts from 0
            intA[1] = 20;
            intA[2] = 30;
            intA[3] = 40;
            intA[4] = 50; // goes upto n-1 where n s the size of array

            //for loop
            Console.Write("For-Loops : ");
            for (int i = 0; i < intA.Length; i++)
                Console.Write(" " + intA[i]);
            //array.Length give you the size of the array

            //for each loop
            Console.WriteLine("");

            Console.Write("For-each Loops : ");
            foreach(int i in intA)
                Console.Write(" " + i);

            //while loop

            Console.WriteLine("");

            Console.Write("While Loops : ");
            int j = 0;

            while( j<intA.Length)
            {
                Console.Write(" " + intA[j]);
                j++;
            }

            //Do-While loop
            Console.WriteLine("");

            Console.Write("Do-While Loops : ");
            int k = 0;
            do
            {
                Console.Write(" " + intA[k]);
                k++;
            } while (k < intA.Length);

            Console.ReadLine();

            //string , errors , break
        }
    }
}
