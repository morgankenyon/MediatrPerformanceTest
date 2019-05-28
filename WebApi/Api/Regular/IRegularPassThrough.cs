using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Regular
{
    public interface IRegularPassThrough
    {
        Task<string> PassThrough(string message);
    }
}
