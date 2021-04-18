using AspNetCoreCrud.ViewModels;
using System.Collections.Generic;
using AspNetCoreCrud.Models;

namespace AspNetCoreCrud.Repository.Department
{
    public  interface IDepartmentRepository
    {

        public IEnumerable<DepartmentVM> GetAll();
        public DepartmentVM GetById(int Id);

        public int Create(Models.Department dept);

        public void Update(Models.Department dept);

        public void Delete(int Id);
    }
}
