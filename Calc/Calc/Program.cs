using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator
    {
        bool _isDirty;

        string _operation;
        decimal _state;

        public decimal Display { get; private set; }

        public void Enter(decimal number)
        {
            _state = number;
            _isDirty = true;
        }

        public void PressPlus()
        {
            _operation = "+";
            if (_isDirty) Calculate();
        }

        public void PressMinus()
        {
            _operation = "-";
            if (_isDirty) Calculate();
        }

        public void PressTimes()
        {
            _operation = "*";
            if (_isDirty) Calculate();
        }

        public void PressEquals()
        {
            if (_isDirty) Calculate();
        }

        void Calculate()
        {
            switch (_operation)
            {
                case "+":
                    Display += _state;
                    break;
                case "-":
                    Display += _state;
                    break;
                case "*":
                    Display *= _state;
                    break;
            }

            _isDirty = false;
        }
    }
}
