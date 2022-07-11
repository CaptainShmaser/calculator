using Calculator.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Storage
{
    public interface IStorageOperationWriter
    {
        string PersistOperationLog(ArithmaticResult[] operationHistory);
    }
}
