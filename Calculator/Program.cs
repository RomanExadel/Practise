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
                Console.WriteLine("Write instruction in form <A> <operation> <B> <operation> <C> ... =");
                var instruction = Console.ReadLine();
                Console.SetCursorPosition(instruction.Length + 1, 1);

                if (Regex.IsMatch(instruction, @"^-?\d{1,17}(\s*[-+ */]\s*-?\d{1,17})*\s*=$"))
                {
                    var simpleAlgorithm = new SimpleAlgorithm();
                    simpleAlgorithm.Algorithm(instruction);
                    Console.Write(simpleAlgorithm.Result);
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
