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

        // Método para CastrateAnimal
        public void CastrateAnimal(int id, string name)
        {
            Console.WriteLine($"El animal {id} - {name} necesita ser castrado.");
        }

        // Método para Hairdress
        public void Hairdress(string name, string coatType)
        {
            Console.Write($"El pelaje del animal {name} es de tipo {coatType}.");
            if (coatType == "peludo")
            {
                Console.WriteLine($"Necesita ser motilado...");
            }
        }

        // Método para ShowInformacion como abstracto de Animal
        public override void ShowInformacion()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Fecha de Nacimiento: {Birthdate}");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso en KG: {WeightInKg}");
            Console.WriteLine($"Estado de la Cría: {BreedingStatus}");
            Console.WriteLine($"Temperamento: {Temperament}");
            Console.WriteLine($"Número de Microchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen de Ladrido: {BarkVolume}");
            Console.WriteLine($"Tipo de Pelaje: {CoatType}");
            Console.WriteLine();
        }
    }
}