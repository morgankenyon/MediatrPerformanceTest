using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private ISingletonPassThrough singletonPassThrough;

        public SingletonController(ISingletonPassThrough singletonPassThrough)
        {
            this.singletonPassThrough = singletonPassThrough;
        }

        [HttpGet]
        public async Task<string> GetMessage(string message)
        {
            return await singletonPassThrough.PassThrough(message);
        }
    }
}