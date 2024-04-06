using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#9 WAP to swap 2 no’s without using a third variable.");
            Console.WriteLine("=============================================");
            Console.WriteLine("User Input the two numbers:->");
            Console.WriteLine("+++++++++++++++++++++++++++++");


            double first_number = 0, second_number = 0;

            //Get the two number form our console 
            Console.WriteLine("Enter First Number:->");
            first_number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number:->");
            second_number = Convert.ToDouble(Console.ReadLine());


            //Result:->
            Console.WriteLine("Result:->");
            Console.WriteLine("+++++++++");
            Console.WriteLine("BEFORE SWAP");
            Console.WriteLine("===========");

            Console.WriteLine(string.Format("First Number: {0}, Second Number {1}", first_number, second_number));

            first_number = first_number + second_number;
            second_number = first_number - second_number;
            first_number = first_number - second_number;

            Console.WriteLine("AFTER SWAP");
            Console.WriteLine("==========");

            Console.WriteLine(string.Format("First Number: {0}, Second Number {1}", first_number, second_number));
            Console.ReadKey();
        }
    }
}
