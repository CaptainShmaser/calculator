using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Types
{
    public class BracketOperation: ArithmaticOperation
    {
        public BracketOperation(List<double> Operands)
        {
            this.OperationType = MathOperationTypes.BRACKETS;
            this.Operands = Operands;

        }
        public BracketOperation()
        {
            this.OperationType = MathOperationTypes.BRACKETS;
        }

        public override double Process()
        {
            //Needs consideration, as this essentially kicks off a recursive operation
            throw new NotImplementedException();
        }
    }
}
