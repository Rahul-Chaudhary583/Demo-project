using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Firstnumber, SecondNumber, Result;
            Console.WriteLine("Enter your first Number");
            Firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            SecondNumber  = int.Parse(Console.ReadLine());

            Result = Firstnumber + SecondNumber;
            Console.WriteLine("The Sum Of two number is: " + Result);
            Console.ReadLine();

        }
        
    }
}
