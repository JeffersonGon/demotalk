using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.APIs.Infra.Interfaces
{
    public interface IModels<T> where T : class
    {
        IEnumerable<T> Values();
    }
}
