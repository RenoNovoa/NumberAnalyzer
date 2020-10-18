using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = "";
            Console.WriteLine("   Welcome to the Number Analyzer Program!   ");
            Console.WriteLine();
            Console.WriteLine("To start the program, Please Enter your Name!");
            string name = Console.ReadLine();

            Console.WriteLine($" Hi {name}, Welcome! Now Please enter a Number between 1 & 100 ");
             int number = int.Parse(Console.ReadLine());
            //int i = number;
            //for (int number = 1; number > 1 && number <= 100 ) { }
            //if(number >= 1 && number <= 100) 
              if (number >= 1 && number <=100)
            {
                

                if (number % 2 != 0)
                {
                    Console.WriteLine($" Amazinh {name}! You enter and Odd Number! ");
                }
                else if ( number % 2 == 0 && number <= 25)
                {
                    Console.WriteLine($"Awesome {name}! Your number is Even and less than 25!");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60 )
                {
                    Console.WriteLine($"Cool {name}! Your enter and  Even Number! ");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"Chevere {name}! The number you entered is Even!");
                }
                else if (number % 2 != 0 && number > 60)
                {
                    Console.WriteLine($"great {name}! The number entered is Odd! ");
                }
               /* else
                {
                    Console.WriteLine($"Sorry {name}! Your number is out of the range");
                }*/


                //Console.WriteLine("press any key to exit program ");
                //Console.ReadLine();
               
                

              }
            else 
            {
                Console.WriteLine($"Sorry {name}! Your number is out of the range");
            }
            Console.WriteLine();
            Console.WriteLine("  press any key to exit program   ");
            Console.ReadLine();
        }
    }
}
