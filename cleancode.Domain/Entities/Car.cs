using cleancode.shared.Abstraction.Domain;

namespace cleancode.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Year { get; set; }

        public Car(string? name, string? color, string? year)
        {
            Name = name;
            Color = color;
            Year = year;
        }
    }
}
