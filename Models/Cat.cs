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
            this.FurLength = furLength;
        }

        // Método para CastrateAnimal
        public void CastrateAnimal(int id, string name)
        {
            Console.WriteLine($"El animal {id} - {name} necesita ser castrado.");
        }

        // Método para Hairdress
        public void Hairdress(string name, string furLength)
        {
            Console.Write($"El pelaje del animal {name} es {furLength}.");
            if (furLength == "largo")
            {
                Console.WriteLine($"Necesita ser motilado...");
            }
        }

        // Método para mostrar la información
        public override void ShowInformacion()
        {
            Console.WriteLine(@$"
            ------------Datos del paciente------------
            Id: {Id}
            Nombre: {Name}
            Fecha de nacimiento: {BirthDate}
            Raza: {Breed}
            Color: {Color}
            Peso en Kg: {WeightInKg}
            Estado de la Cría: {BreedingStatus}
            Longitud del Pelaje: {FurLength}
            ");
        }
    }
}