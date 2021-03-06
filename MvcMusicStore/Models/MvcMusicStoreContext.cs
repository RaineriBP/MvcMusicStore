﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MvcMusicStore.Models
{
    public class MvcMusicStoreContext : IdentityDbContext<ApplicationUser>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcMusicStoreContext() : 
            base("name=MvcMusicStoreContext", 
            throwIfV1Schema: false)
        {

        }

        public static MvcMusicStoreContext Create()
        {
            return new MvcMusicStoreContext();
        }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}
