using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             string text = "some text";
             int num = text.IndexOf("text");
             Console.WriteLine(num);
             Console.WriteLine(2 / 2 + " " + 5 / 2 + " " + 5.0 / 2);
             num++;
             Console.WriteLine(Math.Pow(10,2));
             Console.ReadLine();

            //---------------------------------------------------------
           
            Console.Write("Enter name here: ");
            string name = Console.ReadLine();
            Console.Write("Hello " +name+ " enter your age: ");
            int age = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Hello " + name + " were born in " + (2019-age));
           
            //---------------------------------------------------------

            Console.Write("Enter num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
            

            //#################################

            int[] ages = {10, 22, 124, 21, 56, 3 };

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
             */

            SayHi();

            Console.ReadLine();
        }

        static void SayHi()
        {
            Console.WriteLine("HI!");
        }
    }
}
