using cleancode.shared.Abstraction.Domain;

namespace cleancode.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string? Name { get; set; }

        public Employee(string? name)
        {
            Name = name;
        }
    }
}
