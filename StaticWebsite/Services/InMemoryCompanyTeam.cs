using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StaticWebsite.Services
{
    public class InMemoryCompanyTeam : IEmployeeData
    {
        public string Title { get; set; }
        List<Employee> employees;
        public InMemoryCompanyTeam()
        {
            employees = new List<Employee>()
            {
                new Employee { Id=1,Name="Jack",Intro="Back-end developer etc",socialMedia=new SocialMedia{EmployeeId=1,SocialMediaId=1,Facebook="",Google="",LinkedIn="",Twitter=""}},
                new Employee {Id=2,Name="Josh",Intro="Front-end developer etc",socialMedia=new SocialMedia{EmployeeId=2,SocialMediaId=2,Facebook="https://www.facebook.com/",Google="https://www.google.com/",LinkedIn="https://ro.linkedin.com/",Twitter="https://twitter.com/?lang=ro" } },
                new Employee {Id=3,Name="Johnny",Intro="Back-end developer etc",socialMedia=new SocialMedia{EmployeeId=3,SocialMediaId=3,Facebook="https://www.facebook.com/",Google="https://www.google.com/",LinkedIn="https://ro.linkedin.com/",Twitter="https://twitter.com/?lang=ro" } },
                new Employee {Id=4,Name="Eddy",Intro="Full-stack developer etc",socialMedia=new SocialMedia{EmployeeId=4,SocialMediaId=4,Facebook="https://www.facebook.com/",Google="https://www.google.com/",LinkedIn="https://ro.linkedin.com/",Twitter="https://twitter.com/?lang=ro" } }
            };
            
            

        }
        public IEnumerable<Employee> GetAll()
        {
            return employees.OrderBy(R => R.Id);
        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
            employee.Id = employees.Max(r=>r.Id) + 1;
            employee.socialMedia.EmployeeId= employees.Max(r => r.Id) + 1;
            employee.socialMedia.SocialMediaId = employees.Max(r => r.socialMedia.SocialMediaId) + 1;  
        }
        public void Update(Employee employee)
        {
            var existing = Get(employee.Id);
            if (existing != null)
            {
                existing.Image = employee.Image;
                existing.Name = employee.Name;
                existing.Intro = employee.Intro;
                existing.socialMedia.Facebook = employee.socialMedia.Facebook;
                existing.socialMedia.Google = employee.socialMedia.Google;
                existing.socialMedia.Twitter = employee.socialMedia.Twitter;
                existing.socialMedia.LinkedIn = employee.socialMedia.LinkedIn;
            }
        }

        public int Add(HttpPostedFileBase file, Employee employee)
        {
            throw new NotImplementedException();
        }

        public byte[] GetImageFromDataBase(int Id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}