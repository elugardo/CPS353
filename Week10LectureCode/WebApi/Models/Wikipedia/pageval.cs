using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Wikipedia
{
    public class pageval
    {
        public int pageid { get; set; }
        public int ns { get; set; }
        public string title { get; set; }
        public string extract { get; set; }
    }
}