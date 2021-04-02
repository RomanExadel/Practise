using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System;

namespace Calculator
{
    public class SimpleAlgorithm : IAlgorithm
    {
        private readonly string splitPattern = "([-+ */])|([=])";
        private readonly int numberOfExtraSigns = 1;
        private Calculator calculator = new Calculator();

        public double Algorithm(string instruction)
        {
            CheckValidInstruction(instruction);
            calculator.Reset();
            var splitedExpression = Regex.Split(instruction, splitPattern).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            var firstNumber = double.Parse(splitedExpression[0], CultureInfo.InvariantCulture);
            calculator.Operation('+', firstNumber);

            for (int i = 1; i < splitedExpression.Length - numberOfExtraSigns; i += 2)
            {
                var @operator = char.Parse(splitedExpression[i]);
                double operand;

                if (IsDouble(splitedExpression[i + 1]))
                {
                    operand = double.Parse(splitedExpression[i + 1], CultureInfo.InvariantCulture);
                }
                else
                {
                    i++;
                    operand = -double.Parse(splitedExpression[i + 1], CultureInfo.InvariantCulture);
                }

                calculator.Operation(@operator, operand);
            }

            return calculator.CurrentValue;
        }

        public void CheckValidInstruction(string instruction)
        {
            if (!Regex.IsMatch(instruction, @"^-?\d{1,17}(\.\d+)?(\s*[-+ */]\s*-?\d{1,17}(\.\d+)?)*\s*$"))
            {
                throw new ArgumentException("Invalid input");
            }
        }

        public bool IsDouble(string operand)
        {
            if (double.TryParse(operand, out _))
            {
                return true;
            }

            return false;
        }
    }
}
