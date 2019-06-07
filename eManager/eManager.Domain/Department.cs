using System;
using System.Collections.Generic;
using System.Text;

namespace eManager.Domain
{
    public class Department
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
