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

        public string Text { get; set; }

        //Will need to add bits to containerize media, maybe reference, text position, etc?

    }
}
