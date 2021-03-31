using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    class SimpleAlgorithm
    {
        private readonly string splitPattern = "(?<=[()-+*/])|(?=[()-+*/])|([=])";
        private readonly int numberOfExtraSigns = 1;
        private User user = new User();

        public long Result
        {
            get => user.CurrentValue;
        }

        public void Algorithm(string instruction)
        {
            var splitedExpression = Regex.Split(instruction, splitPattern).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var firstNumber = long.Parse(splitedExpression[0]);
            user.Compute('+', firstNumber);

            for (int i = 1; i < splitedExpression.Length - numberOfExtraSigns; i += 2)
            {
                var @operator = char.Parse(splitedExpression[i]);
                var operand = long.Parse(splitedExpression[i + 1]);
                user.Compute(@operator, operand);
            }
        }
    }
}
