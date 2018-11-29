using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RdvbDotNetCoreRazor.Data
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
