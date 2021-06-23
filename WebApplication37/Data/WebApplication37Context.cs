using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication37.Data
{
    public class WebApplication37Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication37Context() : base("name=WebApplication37Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication37.Models.Tour> Tours { get; set; }

        public System.Data.Entity.DbSet<WebApplication37.Models.UserTour> UserTours { get; set; }
    }
}
