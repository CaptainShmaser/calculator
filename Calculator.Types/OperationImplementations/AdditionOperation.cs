using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Types
{
    public class AdditionOperation : ArithmaticOperation
    {
        public AdditionOperation(List<double> Operands)
        {
            this.OperationType = MathOperationTypes.ADDITION;
            this.Operands = Operands;
        }
        public AdditionOperation()
        {
            this.OperationType = MathOperationTypes.ADDITION;
        }

        public override double Process()
        {
            double result = 0;
            foreach (double Operand in Operands)
            {
                result = result + Operand;
            }

            this.OperationResult = result;
            return result;

        }
    }
}
