using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class GlobalYouthWebContextDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GlobalYouthWebContextDB() : base("name=GlobalYouthWebContextDB")
        {
        }

        
        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.About> Abouts { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Gallery> Galleries { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Index> Indices { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Blog> Blogs { get; set; }

        public System.Data.Entity.DbSet<GlobalYouthWeb.Models.Comments> Comments { get; set; }
    }
}
