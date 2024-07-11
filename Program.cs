using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing example
            int number = 100;  //assignment of value of 100 to integer variable number
            object obj = number; // the value of number is boxed to object type named obj
            Console.WriteLine("The value of obj is " +obj);

            //unboxing example
            object obj1 = 100; //assignment of value of 100 to object named obj1
            int number1 = (int)obj1; //the value of obj1 is unboxed to integer type variable named number1
            Console.WriteLine("The value of number1 is " +number1);
        }
    }
}
