using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class ManagerApp
    {
        // Método estático para crear un perro
        public static Dog CreateDog()
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

            Console.Write("Temperamento (Timido, Normal, Agresivo): ");
            string? temperament = Console.ReadLine().Trim().ToLower();

            Console.Write("Número de Microchip: ");
            string? microchipNumber = Console.ReadLine().Trim().ToLower();

            Console.Write("Volumen de Ladrido: ");
            string? barkVolume = Console.ReadLine().Trim().ToLower();

            Console.Write("Tipo de Pelaje (sin pelo, pelo corto, pelo mediano, pelo largo): ");
            string? coatType = Console.ReadLine().Trim().ToLower();

            if (temperament == "Timido" || temperament == "Normal" || temperament == "Agresivo")
            {
                Console.WriteLine("Ingresa el temperamento de tu perro (Timido, Normal, Agresivo) => ");
                var newdog = new Dog(id, name, birthDate, breed, color, Convert.ToDouble(weightInKg), Convert.ToBoolean(breedingStatus), temperament, microchipNumber, barkVolume, coatType);
                return newdog;
            }
            else if (coatType == "sin pelo" || coatType == "pelo corto" || coatType == "pelo mediano" || coatType == "pelo largo")
            {
                Console.WriteLine("Ingresa el tipo de pelaje de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) => ");
                var newdog = new Dog(id, name, birthDate, breed, color, Convert.ToDouble(weightInKg), Convert.ToBoolean(breedingStatus), temperament, microchipNumber, barkVolume, coatType);
                return newdog;
            }
            else
            {
                Console.WriteLine("No se pudo crear el perro, vuelve a intentarlo.");
                return CreateDog();
            }
        }

        // Método estático para crear un gato
        public static Cat CreateCat()
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
            string furLength = Console.ReadLine().Trim().ToLower();

            var newCat = new Cat(id, name, birthDate, breed, color, Convert.ToDouble(weightInKg), Convert.ToBoolean(breedingStatus), furLength);
            return newCat;
        }

        // Método estático para mostar Header
        public static void ShowHeader()
        {
            Console.WriteLine(@$"
        ==============================================================================
        |                            Veterinaria RIWI                                |
        ==============================================================================
        ");
        }

        // Método estático para mostar Footer
        public static void ShowFooter()
        {
            Console.WriteLine(@$"
        ==============================================================================
        |                          Gracias por tu visita                             |
        ==============================================================================
        ");
        }

        // Método estático para mostar Separador
        public static void ShowSeparator()
        {
            Console.WriteLine(@$"
        ==============================================================================
        ");
        }

        // Método para imprimir un menú
        public static void PrintMenu()
        {
            Console.WriteLine(@$"
        |                             0.  Salir del Menú                              |
        |                             1.  Agregar Perro                               |
        |                             2.  Mostrar Perros                              |
        |                             3.  Editar Perro                                |
        |                             4.  Eliminar Perro                              |
        |                             5.  Agregar Gato                                |
        |                             6.  Mostrar Gatos                               | 
        |                             7.  Editar Gato                                 |
        |                             8.  Eliminar Gato                               |
        |                             9.  Mostrar Pacientes                           |
        |                             10. Mostrar por Tipo                            |
        |                             11. Buscar por ID                               |
        ");
            Console.Write("Selecciona una opción: ");
        }

        //Método para pausar el menú
        public static void StopMenu()
        {
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}