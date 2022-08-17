using System;

namespace Que_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num1 =int.Parse(Console.ReadLine());
            int num2 = num1 % 10;
            EnglishName(num2);
        }
        public static void EnglishName(int number)
        {
            switch(number)
            {
                case 0 : 
                Console.WriteLine("Zero");
                break;

                case 1 :
                Console.WriteLine("one");
                break;

                case 2 :
                Console.WriteLine("two");
                break;

                case 3 :
                Console.WriteLine("three");
                break;
                
                case 4 :
                Console.WriteLine("four");
                break;
                
                case 5 :
                Console.WriteLine("five");
                break;
                
                case 6 :
                Console.WriteLine("six");
                break;
                
                case 7 :
                Console.WriteLine("seven");
                break;
                
                case 8 :
                Console.WriteLine("eight");
                break;
                
                case 9 :
                Console.WriteLine("nine");
                break;

                default :
                Console.WriteLine();
                break;
            }
        }

    }
}
