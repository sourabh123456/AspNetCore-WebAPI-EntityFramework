using AspNetCoreCrud.Models;
using AspNetCoreCrud.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCrud.Repository.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {

        EmployeeDBContext db;
        public EmployeeRepository(EmployeeDBContext _db)
        {
            db = _db;
        }
        public int Create(EmpDetail emp)
        {
            int result = 0;
            if (db != null)
            {
                db.EmpDetails.Add(emp);
                db.SaveChanges();
                result = emp.Id;
                return result;
            }
            return 0;
        }

        public void Delete(int Id)
        {
            if (db != null)
            {
                var emp = db.EmpDetails.FirstOrDefault(x => x.Id == Id);
                if (emp != null)
                {
                    db.EmpDetails.Remove(emp);
                    db.SaveChanges();
                }
            }
        }

        public IEnumerable<EmployeeVM> GetAll()
        {
            IEnumerable<EmployeeVM> emplist = new List<EmployeeVM>();
            if (db != null)
            {
                emplist = from p in db.EmpDetails
                          select new EmployeeVM
                          {
                              Email = p.Email,
                              EmpCode = p.EmpCode,

                              EmpName = p.EmpName,
                              Id = p.Id,
                              Location = p.Location,
                              Salary = p.Salary
                          };


            }

            return emplist;
        }

        public EmployeeVM GetById(int Id)
        {
            EmployeeVM emp = new EmployeeVM();
            if (db != null)
            {
                emp = (from p in db.EmpDetails
                       where p.Id == Id
                       select new EmployeeVM
                       {
                           Email = p.Email,
                           EmpCode = p.EmpCode,

                           EmpName = p.EmpName,
                           Id = p.Id,
                           Location = p.Location,
                           Salary = p.Salary
                       }).FirstOrDefault();


            }

            return emp;
        }

        public void Update(EmpDetail emp)
        {
            if (db != null)
            {
                db.EmpDetails.Update(emp);
                db.SaveChanges();
            }
        }
    }
}
