using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bot.Controllers
{
    public class SlackController : ApiController
    {
        public void SendMessage(string mss, string channel)
        {

        }

        public string GetReturn(dynamic input)
        {
            return input + "";
        }
    }
}
