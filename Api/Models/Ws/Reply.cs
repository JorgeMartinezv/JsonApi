using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Ws
{
    public class Reply
    {
        public string message { get; set; }

        public int result { get; set; }

        public object data { get; set; }
    }
}