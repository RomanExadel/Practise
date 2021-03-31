using System;
using System.Collections.Generic;

namespace Calculator
{
    class User
    {
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public long CurrentValue
        {
            get => _calculator.CurrentValue;
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, long operand)
        {
            Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            _commands.Add(command);
            _current++;
        }
    }
}

