using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Regular;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegularController : ControllerBase
    {
        private IRegularPassThrough regularPassThrough;

        public RegularController(IRegularPassThrough regularPassThrough)
        {
            this.regularPassThrough = regularPassThrough;
        }

        [HttpGet]
        public async Task<string> GetMessage(string message)
        {
            return await regularPassThrough.PassThrough(message);
        }
    }
}