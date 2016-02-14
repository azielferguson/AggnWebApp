using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AggnWebApp.Models
{
    public class AggnWebAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AggnWebAppContext() : base("name=AggnWebAppContext")
        {
        }

        public System.Data.Entity.DbSet<AggnWebApp.Models.Article> Articles { get; set; }

        public System.Data.Entity.DbSet<AggnWebApp.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<AggnWebApp.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<AggnWebApp.Models.Publication> Publications { get; set; }

        public System.Data.Entity.DbSet<AggnWebApp.Models.Role> Roles { get; set; }
    }
}
