//Created by Kent Butler
//Created on 1/16/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine(" ");
                int enteredValue = ValidInteger();
                Console.WriteLine(" ");
                Console.WriteLine("Number \t\tSquared \tCubed");
                Console.WriteLine("====== \t\t======= \t=====");

                GetSquareCubed(enteredValue, 0);
            } while (RunAgain());

        }

        private static bool RunAgain()
        {
            string input;
            bool correctRespone = true;
            while (correctRespone)
            {
                Console.Write("Would you like to run the application again? (y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    correctRespone = false;
                    Console.WriteLine("Goodbye.");
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    Console.WriteLine("Starting Over.");
                    correctRespone = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                    continue;
                }
            }
            return false; //should never get hit needed to make it happy.
        }

        private static void GetSquareCubed(int num, int timesRan)
        {
            if(timesRan<num)
            {
                timesRan++;
                Console.WriteLine(timesRan + "\t \t" + Squared(timesRan) +
                    "\t \t" + Cubed(timesRan));
                GetSquareCubed(num, timesRan);
            }
            else
            {
                //not needed just more comfortable adding this
            }
        }

        public static int ValidInteger()
        {
            String input;
            bool validInput;
            int inputNum;

            Console.Write("Please Enter a number: ");

            do
            {
                input = Console.ReadLine();
                validInput = int.TryParse(input, out inputNum);
                if (!validInput)
                {
                    Console.WriteLine("Please type a valid Number");
                    validInput = false;
                }
                else if (inputNum < 1)
                {
                    Console.WriteLine("Please type a number greater than zero.");
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            return inputNum;
        }

        public static int Squared(int num)
        {
            return (num * num);
        }

        public static int Cubed(int num)
        {
            return (Squared(num) * num);
        }
    }
}
