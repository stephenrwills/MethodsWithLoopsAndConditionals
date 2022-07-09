using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        #region Lukewarm Section
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void numbersUpByThree()
        {
            for (int i = 3; i < 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool areNumbersEqual(int num1, int num2)
        {
            if (num1 != num2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool isEvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool legalVotingAge(int age)
            {
               if (age >= 18)
                {
                    Console.WriteLine("You can Vote!");
                    return true;    
                }
                else
                {
                    Console.WriteLine($"You are too young to vote");
                    return false;
                }
            }

        #endregion

        #region Heatin up Section

        public static bool isNumberInRange(int userInput)
        {
            
            Console.WriteLine("Please enter a number between -10 and 10");
            userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine("Your number is in the specified range");
                return true;
            }
            else
            {
                Console.WriteLine("Your number is not in the specified range");
                return false;
            }
        }
        
        public static void MultiplicationTable()
        {
            Console.WriteLine("Please enter the number you want to show the multiplication table of");
            int num1;
            num1 = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 12; i++)
            {
                int product = i * num1;
                Console.WriteLine($"{i} X {num1} = {product} \n");
            }

            #endregion
        }
    }



}

