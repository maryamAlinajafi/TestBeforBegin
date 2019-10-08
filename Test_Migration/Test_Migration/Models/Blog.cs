using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Migration.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Owner { get; set; }
        

        //relation:
        public virtual ICollection<Post> Posts { get; set; }

    }
}