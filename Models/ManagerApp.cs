using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class ManagerApp
    {
        //metodo para crear un perro
        public static Dog CreateDog()
        {
            // Método para solicitar información del Perro
            Console.WriteLine("Datos del perro");

            Console.WriteLine("Ingrese el Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            DateOnly birthdate1 = DateOnly.FromDateTime(birthdate);
            Console.WriteLine("Ingrese el tipo de raza: ");
            string breed = Console.ReadLine();
            Console.WriteLine("Ingrese el color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en kg: ");
            double weightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese si el perro se encuentra en estado de castración (true/false): ");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de temperamento(Tímido, Normal o Agresivo.): ".ToLower());
            string temperament = Console.ReadLine().ToLower();  // se convierte a minúsculas para comparar con los valores posibles.
            if (temperament != "timido" && temperament != "normal" && temperament != "agresivo".ToLower()) // se realizan validaciones con un ifelse
            {
                Console.WriteLine("Opcion inválida.");
                return CreateDog();
            }

            Console.WriteLine("Ingrese el número de microchip");
            string microShipNumber = Console.ReadLine();
            Console.WriteLine("Ingrese que tan fuerte ladra".ToLower());
            string barkVolume = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de pelo (Sin pelo, Pelo corto, Pelo mediano, Pelo largo.)".ToLower());
            string coatType = Console.ReadLine();
            if (coatType != "sin pelo" && coatType != "pelo corto" && coatType != "pelo mediano" && coatType != "pelo largo".ToLower())
            {
                Console.WriteLine("Opcion inválida");
                return CreateDog();
            }

            var newDog = new Dog(id, name, birthdate1, breed, color, weightInKg, breedingStatus, temperament, microShipNumber, barkVolume, coatType);

            return newDog;
        }

        public static Cat CreateCat()
        {
            Console.WriteLine("Por favor ingrese los siguientes datos del gato");

            Console.WriteLine("Ingrese el Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
            DateOnly birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de raza: ");
            string breed = Console.ReadLine();
            Console.WriteLine("Ingrese el color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en kg: ");
            double weightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese si el gato se encuentra en estado de castración (true/false): ");
            bool breedingStatus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del pelo (Sin pelo, Pelo corto, Pelo mediano, Pelo largo): ");
            string furLenght = Console.ReadLine();
            if (furLenght != "sin" && furLenght != "corto" && furLenght != "mediano" && furLenght != "largo".ToLower())
            {
                Console.WriteLine("Opcion inválida");
                return CreateCat();

            }// se realizan validaciones con un ifelse para validar que el usuario este ingresando bien los datos
            var newCat = new Cat(id, name, birthdate, breed, color, weightInKg, breedingStatus, furLenght);
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