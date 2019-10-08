using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Migration.Models
{
    public class Post
    {

        public int PostId { get; set; }
        public string Author { get; set; }


        //relation:
        public virtual Blog blog { get; set;}
        public virtual int blogId { get; set; }

    }
}