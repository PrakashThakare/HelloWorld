using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class AddTwoNo
    {
        public static void Add()
        {
            Console.WriteLine("Enter 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Addition is :" + c);
        }
    }
}
