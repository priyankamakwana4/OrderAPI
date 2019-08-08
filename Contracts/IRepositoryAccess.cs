using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryAccess
    {
        string PostOrder(Order orderobj);
    }
}
