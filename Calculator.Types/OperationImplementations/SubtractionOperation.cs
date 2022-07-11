using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Types
{
    public class SubtractionOperation : ArithmaticOperation
    {
        public SubtractionOperation(List<double> Operands)
        {
            this.OperationType = MathOperationTypes.SUBTRACTION;
            this.Operands = Operands;
        }
        public SubtractionOperation()
        {
            this.OperationType = MathOperationTypes.SUBTRACTION;
        }

        public override double Process()
        {
            double result = 0;
            foreach (double Operand in Operands)
            {
                result = result - Operand;
            }

            this.OperationResult = result;
            return result;

        }
    }
}
