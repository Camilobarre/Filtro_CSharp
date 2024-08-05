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

            // Datos quemados
            this.Dogs.Add(new Dog(5, "Juan", new DateOnly(2020, 5, 23), "Perro", "Negro", 58, false, "Timido", "ABC123", "Bulloso", "Pelo mediano"));
            this.Dogs.Add(new Dog(1, "Carlos", new DateOnly(2015, 5, 15), "Perro", "Cafe", 40, true, "Normal", "DEF456", "Bulloso", "Pelo corto"));
            this.Dogs.Add(new Dog(2, "Enrique", new DateOnly(2021, 5, 23), "Perro", "Blanco", 58, false, "Timido", "GHI789", "Bulloso", "Pelo mediano"));
            this.Dogs.Add(new Dog(3, "Toby", new DateOnly(2017, 5, 15), "Perro", "Negro", 40, true, "Normal", "JKL123", "Bulloso", "Pelo largo"));
            this.Dogs.Add(new Dog(4, "Calidoso", new DateOnly(2019, 5, 23), "Perro", "Negro", 58, false, "Timido", "MNO456", "Bulloso", "Pelo largo"));
            this.Dogs.Add(new Dog(6, "Azarozo", new DateOnly(2023, 5, 15), "Perro", "Cafe", 40, true, "Normal", "PQR789", "Bulloso", "Pelo corto"));
            this.Cats.Add(new Cat(5, "Juan", new DateOnly(2020, 5, 23), "Gato", "Negro", 58, false, "Pelo largo"));
            this.Cats.Add(new Cat(1, "Carlos", new DateOnly(2015, 5, 15), "Gato", "Cafe", 40, true, "Pelo mediano"));
            this.Cats.Add(new Cat(2, "Enrique", new DateOnly(2021, 5, 23), "Gato", "Blanco", 58, false, "Pelo mediano"));
            this.Cats.Add(new Cat(3, "Toby", new DateOnly(2017, 5, 15), "Gato", "Negro", 40, true, "Pelo largo"));
            this.Cats.Add(new Cat(4, "Calidoso", new DateOnly(2019, 5, 23), "Gato", "Negro", 58, false, "Pelo largo"));
            this.Cats.Add(new Cat(6, "Azarozo", new DateOnly(2023, 5, 15), "Gato", "Cafe", 40, true, "Pelo corto"));
        }

        // Constructor vacío de VeterinaryClinic
        public VeterinaryClinic()
        {
        }

        // Método para guardar un perro
        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
            Console.WriteLine("Perro guardado con éxito.");
        }

        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
            Console.WriteLine("Gato guardado con éxito.");
        }


        // Método para editar un perro
        public void UpdateDog(List<Dog> dogs, int Id)
        {
            var dogEdit = dogs.Find(i => i.GetId() == Id);
            if (dogEdit != null)
            {
                Console.WriteLine(@"Que dato de la mascota deseas editar:
                            1. Peso en Kg
                            2. Estado de la cría
                            3. Temperamento
                            4. Número de Microchip
                            5. Tipo de pelaje");
                string editar = Console.ReadLine();

                switch (editar)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nuevo peso en Kg");
                        var newWeightInKg = Convert.ToDouble(Console.ReadLine());
                        dogEdit.SetWeightInKg(newWeightInKg);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nuevo estado de catracion");
                        var newbreedingStatus = Convert.ToBoolean(Console.ReadLine());
                        dogEdit.BreedingStatus = newbreedingStatus;
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el nuevo temperamento");
                        var newtemperament = Console.ReadLine().ToLower();
                        if (newtemperament != "timido" && newtemperament != "normal" && newtemperament != "agresivo".ToLower())
                        {
                            Console.WriteLine("Opcion inválida");
                        }
                        dogEdit.Temperament = newtemperament;
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el nuevo numero de microShip");
                        var newmicroShipNumber = Console.ReadLine();
                        dogEdit.MicrochipNumber = newmicroShipNumber;
                        break;
                    case "5":
                        Console.WriteLine("Ingrese la nueva longitud de pelo");
                        var newcoatType = Console.ReadLine().ToLower();
                        if (newcoatType != "Sin pelo" && newcoatType != "Pelo corto" && newcoatType != "Pelo mediano" && newcoatType != "Pelo largo".ToLower())
                        {
                            dogEdit.CoatType = newcoatType;
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        // Método para editar un gato
        public void UpdateCat(List<Cat> cats, int Id)
        {
            var catEdit = cats.Find(i => i.GetId() == Id);
            if (catEdit != null)
            {
                Console.WriteLine(@"Que dato de la mascota deseas editar:
                            1. Peso en Kg
                            2. Estado de la cría
                            5. Longitud del pelaje");
                string editar = Console.ReadLine();

                switch (editar)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nuevo peso en Kg: ");
                        var newWeightInKg = Convert.ToDouble(Console.ReadLine());
                        catEdit.SetWeightInKg(newWeightInKg);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nuevo estado de catracion (true/false): ");
                        var newbreedingStatus = Convert.ToBoolean(Console.ReadLine());
                        catEdit.BreedingStatus = newbreedingStatus;
                        break;

                    case "3":
                        Console.WriteLine("Ingrese la nueva longitud de pelo: ");
                        var newFurLenght = Console.ReadLine().ToLower();
                        if (newFurLenght != "Sin pelo" && newFurLenght != "Pelo corto" && newFurLenght != "Pelo mediano" && newFurLenght != "Pelo largo".ToLower())
                        {
                            catEdit.FurLenght = newFurLenght;
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }
        // Método para eliminar un perro por ID
        public void DeleteDog(List<Dog> dogs, int Id)
        {
            Console.WriteLine("Ingrese el Id de su perro: ");
            var dogDelete = dogs.Find(i => i.GetId() == Id);
            if (dogDelete != null)
            {
                dogs.Remove(dogDelete);
                Console.WriteLine("Perro eliminado con éxito.");
            }
        }
        // Método para eliminar un gato por ID
        public void DeleteCat(List<Cat> cats, int Id)
        {
            Console.WriteLine("Ingrese el Id de su gato: ");
            var catDelete = cats.Find(i => i.GetId() == Id);
            if (catDelete != null)
            {
                cats.Remove(catDelete);
                Console.WriteLine("Gato eliminado con éxito.");
            }
        }
        // Método para mostrar todos los pacientes
        public void ShowAllPatients()
        {
            foreach (var dog in Dogs)
            {
                dog.ShowInformacion();
                ManagerApp.ShowSeparator();
            }
            foreach (var cat in Cats)
            {
                cat.ShowInformacion();
                ManagerApp.ShowSeparator();
            }

        }
        // Método para mostrar los pacientes por tipo
        public void ShowAnimals(string type)
        {
            if (type == "Perro".ToLower())
            {
                foreach (var dog in Dogs)
                {
                    dog.ShowInformacion();
                    ManagerApp.ShowSeparator();
                }
            }
            else if (type == "Gato".ToLower())
            {
                foreach (var cat in Cats)
                {
                    cat.ShowInformacion();
                    ManagerApp.ShowSeparator();
                }
            }
            else
            {
                Console.WriteLine("Tipo de animal invalido.");
            }
        }
        // Método para mostrar pacientes por ID
        public void ShowPatient(int Id)
        {
            var dog = Dogs.Find(i => i.GetId() == Id);
            if (dog != null)
            {
                dog.ShowInformacion();
                ManagerApp.ShowSeparator();
            }
            else
            {
                var cat = Cats.Find(c => c.GetId() == Id);
                if (cat != null)
                {
                    cat.ShowInformacion();
                    ManagerApp.ShowSeparator();
                }
                else
                {
                    Console.WriteLine("Mascota no encontrada.");
                    ManagerApp.ShowSeparator();
                }
            }
        }
        // Método para pausar el menú
        public static void PausarMenu()
        {
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadKey();

        }

    }
}