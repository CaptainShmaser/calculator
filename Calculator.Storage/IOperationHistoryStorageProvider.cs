using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Storage
{
    public interface IOperationHistoryStorageProvider
    {
        IStorageOperationReader Reader { get; }
        IStorageOperationWriter Writer { get; }
    }
}
