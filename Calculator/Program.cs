using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write instruction in form <A> <operation> <B> =");
                var instruction = Console.ReadLine();
                Console.SetCursorPosition(instruction.Length + 1, 1);

                if (Regex.IsMatch(instruction, @"^\-?\d{1,17}\s+[\+\-*/]\s+\-?\d{1,17}\s+=$"))
                {
                    var splitedExpression = instruction.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var @operator = char.Parse(splitedExpression[1]);
                    var leftOperand = long.Parse(splitedExpression[0]);
                    var rightOperand = long.Parse(splitedExpression[2]);

                    var user = new User();
                    user.Compute('+', leftOperand);
                    user.Compute(@operator, rightOperand);

                    Console.Write(user.CurrentValue);
                }
                else
                {
                    throw new ArgumentException("Invalid input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
