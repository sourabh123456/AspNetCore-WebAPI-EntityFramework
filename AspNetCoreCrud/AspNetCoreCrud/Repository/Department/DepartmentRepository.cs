using AspNetCoreCrud.Models;
using AspNetCoreCrud.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCrud.Repository.Department
{
    public class DepartmentRepository : IDepartmentRepository
    {
        
        EmployeeDBContext db;
        public DepartmentRepository(EmployeeDBContext _db)
        {
            db = _db;
        }


        public int Create(Models.Department dept)
        {
            int result = 0;
            if (db != null)
            {

                db.Departments.Add(dept);
                db.SaveChanges();
                return dept.Id;
            }

            return result;
        }


    

        public void Delete(int Id)
        {
            if (db != null)
            {
                var dept = db.Departments.FirstOrDefault(x => x.Id == Id);
                if (dept != null)
                {
                    db.Departments.Remove(dept);
                    db.SaveChanges();
                }
            }
        }

        public IEnumerable<DepartmentVM> GetAll()
        {
            IEnumerable<DepartmentVM> emplist = new List<DepartmentVM>();
            if (db != null)
            {
                emplist = from p in db.Departments
                          select new DepartmentVM
                          {
                              Id = p.Id,
                              DateCreated = p.DateCreated ,
                              DeptCode = p.DeptCode,
                              DeptName = p.DeptName


                          };


            }

            return emplist;
        }

        public DepartmentVM GetById(int Id)
        {
            DepartmentVM emp = new DepartmentVM();
            if (db != null)
            {
                emp = (from p in db.Departments
                       where p.Id == Id
                       select new DepartmentVM
                       {
                           Id = p.Id,
                           DateCreated = p.DateCreated,
                           DeptCode = p.DeptCode,
                           DeptName = p.DeptName
                          
                                                }).FirstOrDefault();


            }

            return emp;
        }

        public void Update(Models.Department dept)
        {
            if (db != null)
            {
                db.Departments.Update(dept);
                db.SaveChanges();
            }
        }
    }
}
