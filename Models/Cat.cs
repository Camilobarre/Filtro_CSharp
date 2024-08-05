using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class Cat : Animal
    {
        // Propiedades de Cat
        public bool BreedingStatus { get; set; }
        public string FurLenght { get; set; }

        // Constructor de la clase Cat
        public Cat(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string furLenght) : base(id, name, birthDate, breed, color, weightInKg)
        {
            this.BreedingStatus = breedingStatus;
            this.FurLenght = furLenght;
        }
        // Método de herencia de la clase animal
        public override void ShowInformacion()
        {
            Console.WriteLine(@$"
            Information of animal
            Id: {Id}
            Name: {Name}
            Breed: {Breed}
            Color: {Color}
            Weight: {WeightInKg}kg
            Age: {CalculateAgeInMonths} meses
            Breeding Status: {BreedingStatus}
            Fur Lenght: {FurLenght} cm");
        }
        // Método para validar si el animal se castró
        public void CastrateAnimal()
        {
            if (BreedingStatus == false)
            {
                Console.WriteLine("El animal YA se encuentra castrado, no se puede reproducir");
            }
            else
            {
                Console.WriteLine("El animal aun NO se encuentra castrado, aun se puede reproducir");
                BreedingStatus = false;
            }
        }
        // Método para validar si el animal necesita corte
        public void Hairdress()
        {
            if (FurLenght == "Sin pelo")
            {
                Console.WriteLine("No se puede peluquear al gato ya que  no tiene pelaje");
            }
            else
            {
                Console.WriteLine("Se peluqieó al gato");
            }
        }
    }
}