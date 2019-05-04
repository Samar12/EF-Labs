using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Fk_DepartmentId { get; set; }
        public Department department { get; set; }
        public List<Book> books { get; set; }
    }
}
