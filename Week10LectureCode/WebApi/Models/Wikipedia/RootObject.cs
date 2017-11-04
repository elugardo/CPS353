using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Wikipedia
{
    public class RootObject
    {
        public string batchcomplete { get; set; }
        public Query query { get; set; }
        public Limits limits { get; set; }
    }
}