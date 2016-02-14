using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggnWebApp.Models
{
    public class Article
    {
        public int ArticleID { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }
        
        public bool Published { get; set; }

        public bool Public { get; set; }

        public int AuthorUserID { get; set; }
    }
}
