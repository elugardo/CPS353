using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class WikipediaPageExtract
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Extract { get; set; }
    }
}