using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write q to quit");
            int numberOfInstruction = 2;
            do
            {
                try
                {
                    Console.WriteLine("Write instruction in form <A> <operation> <B> <operation> <C> ... =");
                    var instruction = Console.ReadLine();
                    Console.SetCursorPosition(instruction.Length + 1, numberOfInstruction);

                    if (instruction == "q")
                    {
                        break;
                    }

                    var context = new Context(new ReversePolishNotationAlgorithm());
                    Console.WriteLine(context.ExecuteAlgorithm(instruction));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                numberOfInstruction += 2;
            }
            while (true);
        }
    }
}
