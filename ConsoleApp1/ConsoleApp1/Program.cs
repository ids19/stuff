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
            

            //---------------------------------------------------------

            int[] ages = {10, 22, 124, 21, 56, 3 };

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
             

            Console.WriteLine(Greet("Fuck", "ids"));
            

            //---------------------------------------------------------

            bool flag = true;

            while(flag)
            {
                Console.Write("Enter false to stop: ");
                flag = Convert.ToBoolean(Console.ReadLine());
            }

            Console.ReadLine();
            

            bool isOn = true;
            bool isBig = true;

            if(isOn)
            {
                if (isBig)
                {
                    Console.WriteLine("It's ON and BIG!");
                }
                else
                {
                    Console.WriteLine("It's ON");
                }
            }
            else if(isBig)
            {
                Console.WriteLine("It's OFF and BIG!");
            }
            else
            {
                Console.WriteLine("It's OFF ");
            }
           

            Console.WriteLine("Enter 3 numbers below and get the max:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The max number is: " + isMax(num1, num2, num3));
            

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator:");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + Calc(num1, op, num2));
            

            bool flag = true;

            while(flag)
            {
                Console.Write("Write anything to stop, or just press enter to continue: ");
                string check = Console.ReadLine();
                if(check != "")
                {
                    flag = false;
                }
            }

            Console.WriteLine("Goddbye!");
           
            */
            int num = 7;
            int limit = 1;
            while (limit <= 4)
            {
                try
                {
                    Console.Write("Guess the number (between 0-10): ");
                    if (num == Convert.ToInt32(Console.ReadLine()))
                    {
                        Console.Write("You got it right!!! ");
                        limit = 4;
                    }
                    else if(limit < 4)
                    {
                        Console.WriteLine("Try again.. ");
                    }
                    limit++;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("_____________________________________");
                }

                Console.ReadLine();
            }
            /*
    
            Console.WriteLine(getPower(3, 70));

            int[,] numbers =
            {
                {1, 3, 4},
                {4, 3, 4},
                {5, 2, 42}
            };
            int[,] numbers2 = new int[3, 3];
           
            */

        }

        static Int64 getPower(Int64 baseNum, Int64 powerNum)
        {
            Int64 result = 1;
            for(int i=1; i <= powerNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }
        /*
        static int Calc(int num1, string op, int num2)
        {
            if(op == "+")
            {
                return num1 + num2;
            }
            else if(op == "-")
            {
                return num1 - num2;
            }
            else if (op == "x")
            {
                return num1 * num2;
            }
            else if (op == "/")
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Not an operartor.");
                return 0;
            }
        }

        static int isMax(int num1, int num2, int num3)
        {
            if(num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if(num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
        /*
        static string Greet(string curse, string name)
        {
         return (curse + " you " + name);
        }
        */
    }
}
