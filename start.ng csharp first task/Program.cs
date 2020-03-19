using System;

namespace start.ng_csharp_first_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;
            int thirdnumber;
            int result;

            Console.Write("Enter your first number: ");
            firstnumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            secondnumber = Int32.Parse(Console.ReadLine());
            Console.Write("Please Enter your third number: ");
            thirdnumber = Int32.Parse(Console.ReadLine());

            result = firstnumber * secondnumber * thirdnumber;
            Console.WriteLine("Your result is " + result);



        }
    }
}
