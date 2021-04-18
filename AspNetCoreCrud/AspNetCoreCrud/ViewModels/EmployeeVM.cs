using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCrud.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpCode { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}
