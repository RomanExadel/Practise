namespace Calculator
{
    class Calculator
    {
        private long _curr = 0;

        public long CurrentValue
        {
            get => _curr;
        }

        public void Operation(char @operator, long operand)
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
