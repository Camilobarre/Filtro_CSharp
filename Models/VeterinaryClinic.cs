using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    // Se crean las propiedades de la clase VeterinaryClinic 
    public class VeterinaryClinic
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        // Constructor de VeterinayClinic
        public VeterinaryClinic(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        // Constructor de VeterinaryClinic con listas
        public VeterinaryClinic()
        {
            this.Dogs = new List<Dog>();
            this.Cats = new List<Cat>();
        }

        // Método para guardar un perro
        public void SaveDog(Dog newDog)
        {
            Console.WriteLine("Ingresa los datos del perrito: ");

            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nombre: ");
            string? name = Console.ReadLine().Trim().ToLower();

            Console.Write("Fecha de Nacimiento: ");
            DateOnly birthDate = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

            Console.Write("Raza: ");
            string? breed=Console.ReadLine().Trim().ToLower();

            Console.Write("Color: ");
            string? color=Console.ReadLine().Trim().ToLower();

            Console.Write("Peso en KG: ");
            double? weightInKg =Convert.ToByte(Console.ReadLine());

            Console.Write("Estado de la cría: ");
            bool? breedingStatus = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Temperamento: ");
            string? temperament= Console.ReadLine().Trim().ToLower();

            Console.Write("Número de Microchip: ");
            string? microchipNumber = Console.ReadLine().Trim().ToLower();

            Console.Write("Volumen de Ladrido: ");
            string? barkVolume= Console.ReadLine().Trim().ToLower();

            Console.Write("Tipo de Pelaje: ");
            string? coatType= Console.ReadLine().Trim().ToLower();
        }
    }
}