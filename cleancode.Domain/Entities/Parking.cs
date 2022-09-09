using cleancode.shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Domain.Entities
{
    public class Parking:BaseEntity
    {
        public Parking(string name, List<Car> cars, List<Employee> employees)
        {
            Name = name;
            Cars = cars;
            Employees = employees;
        }

        public string? Name { get; set; }    
        public List<Car> Cars { get; set; }
        public List <Employee> Employees { get; set; }  

    }
}
