using cleancode.shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Domain.Entities
{
    public class Employee:BaseEntity
    {
        public Employee(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }    
    }
}
