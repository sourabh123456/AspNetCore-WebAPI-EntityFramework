using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCrud.ViewModels
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
