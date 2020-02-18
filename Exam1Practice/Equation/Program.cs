using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation test = new Equation();

            Console.WriteLine("Please input the value for Left:");
            test.Left = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value for Right");
            test.Right = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What calculation would you like to perform? Please enter a number:" +
                "1-Addition" +
                "2-Subtraction" +
                "3-Multiplication" +
                "4-Left Power" +
                "5-Right Power");
            int answer = Convert.ToInt32(Console.ReadLine());



        }
    }
}
