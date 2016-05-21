using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Contracts
{
    public interface IIocContainer
    {
        object Resolve<T>();
    }
}
