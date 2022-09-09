using cleancode.shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Domain.Entities
{
    public class Car:BaseEntity
    {
        public Car(string? name, string? color, string? year)
        {
            Name = name;
            Color = color;
            Year = year;
        }

        public string? Name { get; set; }  
        public string? Color { get; set; }
        public string? Year { get; set; }    
        
    }
}
