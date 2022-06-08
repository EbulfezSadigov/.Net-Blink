using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class Blog:BaseEntity
    {
        public string Image { get; set; }
        public string Category { get; set; }
        public string BlogSingle { get; set; }
        public string Text { get; set; }
        public string ReadBlog { get; set; }
    }
}
