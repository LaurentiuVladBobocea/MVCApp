using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace StaticWebsite.Services
{
    public class SqlEmployeesData : IEmployeeData
    {
        private readonly EmployeesDbContext db;
        public SqlEmployeesData(EmployeesDbContext db) 
        {
            this.db = db;
        }
        public int Add(HttpPostedFileBase file, Employee employee)
        {
           // employee.Image = ConvertToBytes(file);
            //var Employee = new Employee
            //{
            //    Name = employee.Name,
            //    Image=employee.Image,
            //    Intro=employee.Intro,
            //};
            db.Employees.Add(employee);   
            int i=db.SaveChanges();
            if (i == 1) return 1;
            else
            {
                return 0;
            }
        }

        public Employee Get(int id)
        {
            return db.Employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return from e in db.Employees
                   orderby e.Name
                   select e;
        }

        public void Update(Employee employee)
        {
            var entry = db.Entry(employee);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
        public byte[] GetImageFromDataBase(int Id)
        {
            var q = from temp in db.Employees where temp.Id == Id select temp.Image;
            byte[] cover = q.FirstOrDefault();
            return cover;
        }

        public void Delete(int id)
        {
            var employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}