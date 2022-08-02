using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Task_Given
{
    public class Program
    {
        public void action(string sign)
        {
            Console.WriteLine("Enter First Value");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            double b = Convert.ToDouble(Console.ReadLine());
            double total;
            switch (sign)
            {
                case "+":
                    total = a + b;
                    Console.WriteLine("The addition is " + total);
                    AnswerYES(total);
                    break;
                case "-":
                    total = a - b;
                    Console.WriteLine("The substraction is " + total);
                    AnswerYES(total);
                    break;
                case "*":
                    total = a * b;
                    Console.WriteLine("The multiplication is " + total);
                    AnswerYES(total);
                    break;
                case "/":
                    total = a / b;
                    Console.WriteLine("The division is " + total);
                    AnswerYES(total);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public void AnswerYES(double total)
        {
            Console.WriteLine("Press 'y' for Continue and 'n' for End of the Calculations...");
            string ans = Convert.ToString(Console.ReadLine());
            if (ans == "y")
            {
                Console.WriteLine("Which Operation You Wants to Continue...?");
                string sign = Convert.ToString(Console.ReadLine());
                moreAction(sign, total);
            }
            else
            {
                Console.WriteLine("End of the Calculations...");
            }
        }
        public void moreAction(string sign, double total)
        {
            switch (sign)
            {
                case "+":
                    {
                        action(sign);
                    }
                    break;
                case "-":
                    {
                        action(sign);
                    }
                    break;
                case "*":
                    {
                        action(sign);
                    }
                    break;
                case "/":
                    {
                        action(sign);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Which Operation You Wants to do...?");
            string operation = Convert.ToString(Console.ReadLine());
            Program program = new Program();
            switch (operation)
            {
                case "+":
                    {
                        program.action(operation);
                    }
                    break;
                case "-":
                    {
                        program.action(operation);
                    }
                    break;
                case "*":
                    {
                        program.action(operation);
                    }
                    break;
                case "/":
                    {
                        program.action(operation);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Input...!");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}