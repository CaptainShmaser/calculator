using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic
{
    internal class ArithmaticSorter: System.Collections.IComparer
    {
        public int Compare(Object a, Object b)
        {
            return (new System.Collections.CaseInsensitiveComparer()).Compare(((ArithmaticOperation)b).OperationType, ((ArithmaticOperation)a).OperationType);
        }
    }
}
