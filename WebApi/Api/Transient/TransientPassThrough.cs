using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Transient
{
    public class TransientPassThrough : ITransientPassThrough
    {
        public async Task<string> PassThrough(string message)
        {
            return message;
        }
    }
}
