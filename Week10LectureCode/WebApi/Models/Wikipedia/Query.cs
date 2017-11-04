using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Wikipedia
{
    public class Query
    {
        public Dictionary<string, pageval> pages { get; set; }
    }
}