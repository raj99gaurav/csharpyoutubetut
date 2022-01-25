using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //syntax : <Datatype> [] <name_array>;
            int[] x;
            string[] s;
            //Student[] std; class array

            //Array declaraion & Initalization

            int[] intArray = new int[5];
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] intArray3 = { 1, 2, 3, 4, 5 };

            //Array after declaration
            //Declare

            String[] s1;

            //initalization

            s1 = new string[5] { "raj", "gaurav", "xyz", "youtube", "coding" };
            */

            string[] weekDays; //declare

            weekDays = new string[] { "Sun", "Mon", "Tues", "Wed", "Thrus", "Friday", "Sat" }; // allocation

            //Display
            foreach (string day in weekDays)
                Console.Write(day + " ");
            Console.ReadLine();
        }
    }
}
