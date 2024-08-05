using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            this.Dogs = new List<Dog>();
            this.Cats = new List<Cat>();
        }

        // Constructor de VeterinaryClinic con listas
        public VeterinaryClinic()
        {
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
            string? breed = Console.ReadLine().Trim().ToLower();

            Console.Write("Color: ");
            string? color = Console.ReadLine().Trim().ToLower();

            Console.Write("Peso en KG: ");
            double? weightInKg = Convert.ToByte(Console.ReadLine());

            Console.Write("Estado de la cría: ");
            bool? breedingStatus = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Temperamento: ");
            string? temperament = Console.ReadLine().Trim().ToLower();

            Console.Write("Número de Microchip: ");
            string? microchipNumber = Console.ReadLine().Trim().ToLower();

            Console.Write("Volumen de Ladrido: ");
            string? barkVolume = Console.ReadLine().Trim().ToLower();

            Console.Write("Tipo de Pelaje: ");
            string? coatType = Console.ReadLine().Trim().ToLower();
        }

        // Método para guardar un gato
        public void SaveCat(Cat newCat)
        {
            Console.WriteLine("Ingresa los datos del gatito: ");

            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nombre: ");
            string? name = Console.ReadLine().Trim().ToLower();

            Console.Write("Fecha de Nacimiento: ");
            DateOnly birthDate = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

            Console.Write("Raza: ");
            string? breed = Console.ReadLine().Trim().ToLower();

            Console.Write("Color: ");
            string? color = Console.ReadLine().Trim().ToLower();

            Console.Write("Peso en KG: ");
            double? weightInKg = Convert.ToByte(Console.ReadLine());

            Console.Write("Estado de la cría: ");
            bool? breedingStatus = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Longitud del pelaje: ");
            string? furLength = Console.ReadLine().Trim().ToLower();
        }

        // Método para actualizar un perro
        public void UpdateDog(Dog dog, bool breadingStatus, string temperament, string microchipNumber, string barkVolume, string coatType)
        {
            Console.Write("Ingresa el Id del perro a editar: ");
            var IdEncontrada = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
            Dog? IdFound = Dogs.Find(i => i.GetId() == IdEncontrada);
            if (IdFound != null)
            {
                Console.WriteLine("Ingresa los nuevos datos del perrito: ");

                Console.Write("Id (Deja en blanco para no cambiar): ");
                var input1 = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input1))) IdFound.SetId(input1);

                Console.Write("Nombre (Deja en blanco para no cambiar): ");
                var input2 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input2)) IdFound.SetName(input2);

                Console.Write("Fecha de Nacimiento (Deja en blanco para no cambiar): ");
                var input3 = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));
                if (!string.IsNullOrEmpty(Convert.ToString(input3))) IdFound.SetBirthDate(input3);

                Console.Write("Raza (Deja en blanco para no cambiar): ");
                var input4 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input4)) IdFound.SetBreed(input4);

                Console.Write("Color (Deja en blanco para no cambiar): ");
                var input5 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input5)) IdFound.SetColor(input5);

                Console.Write("Peso en Kg (Deja en blanco para no cambiar): ");
                var input6 = Convert.ToDouble(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input6))) IdFound.SetWeightInKg(input6);

                Console.Write("Estado de la Cría (Deja en blanco para no cambiar): ");
                var input7 = Convert.ToBoolean(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input7))) breadingStatus = input7;

                Console.Write("Temperamento (Deja en blanco para no cambiar: ");
                var input8 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input8)) temperament = input8;

                Console.Write("Número del Microchip (Deja en blanco para no cambiar: ");
                var input9 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input9)) microchipNumber = input9;

                Console.Write("Volumen de Ladrido (Deja en blanco para no cambiar: ");
                var input10 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input10)) barkVolume = input10;

                Console.Write("Tipo de Pelaje (Deja en blanco para no cambiar: ");
                var input11 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input11)) coatType = input11;
            }
            else
            {
                Console.WriteLine("Perrito no encontrado.");
            }
        }

        // Método para actualizar un gato
        public void UpdateCat(Cat cat, bool breadingStatus, string furLength)
        {
            Console.Write("Ingresa el Id del gato a editar: ");
            var IdEncontrada = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
            Cat? IdFound = Cats.Find(i => i.GetId() == IdEncontrada);
            if (IdFound != null)
            {
                Console.WriteLine("Ingresa los nuevos datos del gatito: ");

                Console.Write("Id (Deja en blanco para no cambiar): ");
                var input1 = Convert.ToInt32(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input1))) IdFound.SetId(input1);

                Console.Write("Nombre (Deja en blanco para no cambiar): ");
                var input2 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input2)) IdFound.SetName(input2);

                Console.Write("Fecha de Nacimiento (Deja en blanco para no cambiar): ");
                var input3 = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));
                if (!string.IsNullOrEmpty(Convert.ToString(input3))) IdFound.SetBirthDate(input3);

                Console.Write("Raza (Deja en blanco para no cambiar): ");
                var input4 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input4)) IdFound.SetBreed(input4);

                Console.Write("Color (Deja en blanco para no cambiar): ");
                var input5 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input5)) IdFound.SetColor(input5);

                Console.Write("Peso en Kg (Deja en blanco para no cambiar): ");
                var input6 = Convert.ToDouble(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input6))) IdFound.SetWeightInKg(input6);

                Console.Write("Estado de la Cría (Deja en blanco para no cambiar): ");
                var input7 = Convert.ToBoolean(Console.ReadLine().Trim().ToLower());
                if (!string.IsNullOrEmpty(Convert.ToString(input7))) breadingStatus = input7;

                Console.Write("Longitgud de Pelaje (Deja en blanco para no cambiar: ");
                var input8 = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input8)) furLength = input8;
            }
            else
            {
                Console.WriteLine("Perrito no encontrado.");
            }
        }

        // Método para eliminar un perro
        public void DeleteDog(int id)
        {
            Dogs.RemoveAll(i => i.GetId() == id);
            Console.WriteLine($"El perrito con ID {id} ha sido eliminado");
        }

        // Método para eliminar un gato
        public void DeleteCat(int id)
        {
            Dogs.RemoveAll(i => i.GetId() == id);
            Console.WriteLine($"El gatito con ID {id} ha sido eliminado");
        }
    }
}