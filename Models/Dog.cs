using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class Dog : Animal
    {
        // Se crean las propiedades de la clase Dog
        public bool BreedingStatus { get; set; }
        public string? Temperament { get; set; }
        public string? MicrochipNumber { get; set; }
        public string? BarkVolume { get; set; }
        public string? CoatType { get; set; }

        // Constructor de Dog como herencia de Animal
        public Dog(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string temperament,
        string microchipNumber, string barkVolume, string coatType) : base(id, name, birthDate, breed, color, weightInKg)
        {
            this.BreedingStatus = breedingStatus;
            this.Temperament = temperament;
            this.MicrochipNumber = microchipNumber;
            this.BarkVolume = barkVolume;
            this.CoatType = coatType;
        }
    }
}