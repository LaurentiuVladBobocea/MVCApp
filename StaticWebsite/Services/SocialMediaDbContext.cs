using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StaticWebsite.Services
{
    public class SocialMediaDbContext:DbContext
    {
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}