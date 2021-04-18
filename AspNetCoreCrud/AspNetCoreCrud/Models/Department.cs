using System;
using System.Collections.Generic;

#nullable disable

namespace AspNetCoreCrud.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
