namespace Calculator
{
    class Calculator
    {
        private double _curr = 0;

        public double CurrentValue
        {
            get => _curr;
        }

        public void Operation(char @operator, double operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
        }
    }
}
