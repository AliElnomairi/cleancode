using cleancode.shared.Abstraction.Domain;

namespace cleancode.Domain.Entities
{
    public class Parking : BaseEntity
    {
        public string? Name { get; set; }
        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }

        public Parking() { }

        public Parking(string name, List<Car> cars, List<Employee> employees)
        {
            Name = name;
            Cars = cars;
            Employees = employees;
        }
    }
}
