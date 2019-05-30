using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Singleton
{
    public interface ISingletonPassThrough
    {
        Task<string> PassThrough(string message);
    }
}
