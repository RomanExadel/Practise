using System;

namespace Calculator
{
    class CalculatorCommand : Command
    {
        private char _operator;
        private double _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, double operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public double Operand
        {
            set => _operand = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator) => @operator switch
        {
            '+' => '-',
            '-' => '+',
            '*' => '/',
            '/' => '*',
            _ => throw new ArgumentException("@operator"),
        };
    }
}
