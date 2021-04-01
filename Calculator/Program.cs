using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInstruction = 1;

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

                    if (Regex.IsMatch(instruction, @"^-?\d{1,17}(\.\d+)?(\s*[-+ */]\s*-?\d{1,17}(?:\.\d+)?)*\s*=$"))
                    {
                        var simpleAlgorithm = new SimpleAlgorithm();
                        simpleAlgorithm.Algorithm(instruction);
                        Console.WriteLine(simpleAlgorithm.Result);
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

                numberOfInstruction += 2;
            }
            while (true);
        }
    }
}
