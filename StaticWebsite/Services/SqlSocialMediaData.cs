using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StaticWebsite.Services
{
    public class SqlSocialMediaData : ISocialMediaData
    {
        private readonly SocialMediaDbContext db;
        public SqlSocialMediaData(SocialMediaDbContext db)
        {
            this.db = db;
        }
        public void Add(SocialMedia _socialMedia)
        {
            db.SocialMedias.Add(_socialMedia);
            db.SaveChanges();
        }

        public SocialMedia Get(int id)
        {
            return db.SocialMedias.FirstOrDefault(sm => sm.EmployeeId == id);
        }

        public void Update(SocialMedia _socialMedia)
        {
            var entry = db.Entry(_socialMedia);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}