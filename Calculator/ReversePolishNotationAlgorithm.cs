using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class ReversePolishNotationAlgorithm : IAlgorithm
    {
        public double Algorithm(string instruction)
        {
            CheckValidInstruction(instruction);
            var reversePolishNotation = ConvertStringToPolishNotation(instruction).Split(' ');
            var stack = new Stack<double>();

            for (int i = 0; i < reversePolishNotation.Length; i++)
            {
                switch (reversePolishNotation[i])
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        var val1 = stack.Pop();
                        var val2 = stack.Any() ? stack.Pop() : 0;
                        stack.Push(val2 - val1);
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        var value1 = stack.Pop();
                        var value2 = stack.Pop();
                        stack.Push(value2 / value1);
                        break;
                    default:
                        stack.Push(double.Parse(reversePolishNotation[i], CultureInfo.InvariantCulture));
                        break;
                }
            }

            var result = stack.Pop();

            if (double.IsInfinity(result))
            {
                throw new DivideByZeroException("Result is infinity");
            }

            return result;
        }

        private void CheckValidInstruction(string instruction)
        {
            if (!Regex.IsMatch(instruction, @"^-?\d{1,17}(\.\d+)?(\s*[-+ */]\s*-?\d{1,17}(\.\d+)?)*\s*=$"))
            {
                throw new ArgumentException("Invalid input");
            }
        }

        private string ConvertStringToPolishNotation(string input)
        {
            var stack = new Stack<char>();
            var str = input.Replace(" ", string.Empty);
            var formula = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var x = str[i];

                if (IsOperandus(x))
                {
                    formula.Append(x);
                }
                else if (IsOperator(x))
                {
                    formula.Append(' ');
                    while (stack.Count > 0 && Prior(x) <= Prior(stack.Peek()))
                    {
                        formula.Append(stack.Pop());
                        formula.Append(' ');
                    }

                    stack.Push(x);
                }
                else
                {
                    char y = stack.Pop();
                    formula.Append(' ');
                    formula.Append(y);
                }
            }

            while (stack.Count > 0)
            {
                formula.Append(' ');
                formula.Append(stack.Pop());
            }

            return formula.ToString().Trim();
        }

        private bool IsOperator(char c) => (c == '-' || c == '+' || c == '*' || c == '/');

        private bool IsOperandus(char c) => (c >= '0' && c <= '9' || c == '.');

        private int Prior(char c) => c switch
        {
            '=' => 1,
            '+' => 2,
            '-' => 2,
            '*' => 3,
            '/' => 3,
            _ => throw new ArgumentException("Rossz parameter"),
        };
    }
}
