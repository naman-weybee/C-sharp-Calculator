using System;

namespace Introduction_Task_Given
{
    public class Program
    {
        int count = 0;
        public void Action(string sign)
        {
            Console.WriteLine("Enter First Value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int b = Convert.ToInt32(Console.ReadLine());
            double total;
            try
            {
                switch (sign)
                {
                    case "+":
                        total = a + b;
                        Console.WriteLine("The addition is " + total);
                        break;
                    case "-":
                        total = a - b;
                        Console.WriteLine("The substraction is " + total);
                        break;
                    case "*":
                        total = a * b;
                        Console.WriteLine("The multiplication is " + total);
                        break;
                    case "/":
                        total = a / b;
                        Console.WriteLine("The division is " + total);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                this.count++;
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" Exception Occured {0} Times, Now You have {1} More Chance...! ", count, 4 - count);
                Console.WriteLine("----------------------------------------------------------");
            }
            finally
            {
                ExceptionAnswer(count);
            }
        }
        public void ExceptionAnswer(int count)
        {
            if (this.count <= 3)
            {
                AnswerYES();
            }
            else
            {
                Console.WriteLine("Your Trials Are Over...!");
            }
        }
        public void AnswerYES()
        {
            Console.WriteLine("Press 'y' for Continue and 'n' for End of the Calculations...");
            string ans = Convert.ToString(Console.ReadLine());
            if (ans == "y")
            {
                Console.WriteLine("Which Operation You Wants to Continue...?");
                string sign = Convert.ToString(Console.ReadLine());
                MoreAction(sign);
            }
            else
            {
                Console.WriteLine("End of the Calculations...");
            }
        }
        public void MoreAction(string sign)
        {
            switch (sign)
            {
                case "+":
                    {
                        Action(sign);
                    }
                    break;
                case "-":
                    {
                        Action(sign);
                    }
                    break;
                case "*":
                    {
                        Action(sign);
                    }
                    break;
                case "/":
                    {
                        Action(sign);
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
                        program.Action(operation);
                    }
                    break;
                case "-":
                    {
                        program.Action(operation);
                    }
                    break;
                case "*":
                    {
                        program.Action(operation);
                    }
                    break;
                case "/":
                    {
                        program.Action(operation);
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