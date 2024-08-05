using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class Cat : Animal
    {
        // Se crean las propiedades de la clase Cat
        public bool BreedingStatus { get; set; }
        public string FurLength { get; set; }

        // Constructor de Cat como herencia de Animal
        public Cat(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string furLength)
        : base(id, name, birthDate, breed, color, weightInKg)
        {
            this.BreedingStatus = breedingStatus;
            this.FurLength =furLength;
        }
    }
}