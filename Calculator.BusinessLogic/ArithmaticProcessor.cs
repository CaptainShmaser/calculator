using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic
{
    public class ArithmaticProcessor
    {
        public ArithmaticOperation[] Operations { get; set; }
        public double OperationResult { get; set; }
        public ArithmaticProcessor(ArithmaticOperation[] Operations)
        {
            this.Operations = Operations;
        }

        public double ProcessOperations()
        {
            double result = 0;
            DetermineOperationSequence();
            foreach(ArithmaticOperation Operation in this.Operations)
            {
                //Need to feed in result as the new operand for the next operation, think if I add it to the operands, order of processing within a single operation in BODMAS is irrelevant.
                Operation.Operands.Add(result);
                result = Operation.Process();
            }
            this.OperationResult = result;
            return OperationResult;
        }

        private void DetermineOperationSequence()
        {
            Array.Sort(this.Operations, new ArithmaticSorter());
        }
    }
}
