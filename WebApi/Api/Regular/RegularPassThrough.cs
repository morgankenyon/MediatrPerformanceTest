using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Regular
{
    public class RegularPassThrough : IRegularPassThrough
    {
        public async Task<string> PassThrough(string message)
        {
            return message;
        }
    }
}
