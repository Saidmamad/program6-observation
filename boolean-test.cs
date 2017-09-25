using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int var1, var2;

            while (true)
                {
                    Console.WriteLine("Enter two integers:");
                    
                    var1 = Convert.ToInt32(Console.ReadLine());
                    var2 = Convert.ToInt32(Console.ReadLine());
                    if (isValid(var1, var2))
                    {
                        Console.WriteLine("Print the values");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid values! Try again!");
                    }
                    
           
                }

            Console.WriteLine("\nThe program will exit now!");
            Console.ReadKey();
        }

        static Boolean isValid(int a, int b) { 
            return !(a>10 && b>10);
        }
    }
}
