using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class Comment:BaseEntity
    {
        public string Message { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
