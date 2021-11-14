using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StaticWebsite.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        int Add(HttpPostedFileBase file, Employee employee);
        void Update(Employee employee);
        void Delete(int id);
         byte[] GetImageFromDataBase(int Id);
    }
}
