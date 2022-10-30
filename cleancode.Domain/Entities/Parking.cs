using cleancode.shared.Abstraction.Domain;

namespace cleancode.Domain.Entities
{
    public class Parking : BaseEntity
    {
        public string? Name { get; set; }
        public List<Car>? Cars { get; set; }

        public Parking() { }

        public Parking(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
            
        }
        public void UpdateCar(List<Car> cars) => Cars = cars;
        
    }
}
