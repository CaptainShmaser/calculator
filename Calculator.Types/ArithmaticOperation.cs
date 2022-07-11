using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Types
{
    public abstract class ArithmaticOperation
    {
        public MathOperationTypes OperationType { get; set; }
        public List<double> Operands{ get; set; }
        public double OperationResult { get; set; }

        public abstract double Process();
    }
}
