using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebsite.Services
{
    interface ISocialMediaData
    {
        SocialMedia Get(int id);
        void Add(SocialMedia _socialMedia);
        void Update(SocialMedia _socialMedia);

    }
}
