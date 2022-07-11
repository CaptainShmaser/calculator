using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Types;

namespace Calculator.Storage
{
    public interface IStorageOperationReader
    {
        ArithmaticResult[] ReadHistoricOperations  (string Path);
    }
}
