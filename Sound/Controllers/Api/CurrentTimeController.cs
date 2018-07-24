using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sound.Controllers.Api
{
    public class CurrentTimeController : ApiController
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
