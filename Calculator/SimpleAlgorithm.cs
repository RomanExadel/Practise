using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Calculator
{
    class SimpleAlgorithm
    {
        private readonly string splitPattern = "([-+ */])|([=])";
        private readonly int numberOfExtraSigns = 1;
        private User user = new User();

        public double Result
        {
            get => user.CurrentValue;
        }

        public void Algorithm(string instruction)
        {
            var splitedExpression = Regex.Split(instruction, splitPattern).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            var firstNumber = double.Parse(splitedExpression[0], CultureInfo.InvariantCulture);
            user.Compute('+', firstNumber);

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

                user.Compute(@operator, operand);
            }
        }

        public bool IsDouble(string operand)
        {
            if (double.TryParse(operand, out double result))
            {
                return true;
            }

            return false;
        }
    }
}
