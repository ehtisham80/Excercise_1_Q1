using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num_1 = 0;
            Int32 num_2 = 0;
            String operation;
            Int32 result = 0;

            Console.WriteLine("BASIC CALCULATOR");
            Console.Write("Please Enter Your First Number:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Your Second Number:");
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Desired Operation: (+ , - , * , /)");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                result = num_1 + num_2;
            }
            if (operation == "-")
            {
                result = num_1 - num_2;
            }
            if (operation == "*")
            {
                result = num_1 * num_2;
            }
            if (operation == "/")
            {
                result = num_1 / num_2;
            }

            Console.WriteLine("Your Desired Operation   " + operation + "   Applied");
            
            Console.WriteLine("The Result Of Your Given Number is:{0}", result);
            //Console.WriteLine("The Result Of Your Given Number is:" + result);
            
        }
    }
}
