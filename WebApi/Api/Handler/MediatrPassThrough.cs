using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Handler
{
    public class MediatrPassThrough : IRequest<string>
    {
        public MediatrPassThrough(string Message)
        {
            this.Message = Message;
        }
        public string Message { get; set; }
    }
}
