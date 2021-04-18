using AspNetCoreCrud.Models;
using AspNetCoreCrud.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCrud.Repository.Employee
{
   public interface IEmployeeRepository
    {

        public IEnumerable<EmployeeVM> GetAll();
        public EmployeeVM GetById(int Id);

        public int Create(EmpDetail emp);

        public void Update(EmpDetail emp);

        public void Delete(int Id);

    }
}
