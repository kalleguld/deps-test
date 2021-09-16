using Microsoft.AspNetCore.Mvc;
using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB.Controllers
{
    public class StringController:ControllerBase
    {
        [HttpGet("api/string")]
        public string Get()
        {
            return new StringProvider().Provide();
        }
    }
}
