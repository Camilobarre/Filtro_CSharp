using FiltroCSharp_CamiloBarreneche.Models;

Console.Clear();

// Creamos una instancia
// var veterinaryClinic = new VeterinaryClinic();

// Creamos ciclo While para el menú
var bandera = true;

var veterinaryClinic = new VeterinaryClinic("Veterinaria Riwi", "Calle 123");
while (bandera)
{
    ManagerApp.ShowHeader();
    ManagerApp.PrintMenu();
    var opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            // Salir del Programa
            ManagerApp.ShowFooter();
            bandera = false;
            break;
        case 1:
            // Agregar Perro
            var newDog = ManagerApp.CreateDog();
            veterinaryClinic.SaveDog(newDog);
            ManagerApp.StopMenu();
            break;
        case 2:
            // Mostrar Perros
            veterinaryClinic.ShowAnimals("Perro");
            ManagerApp.StopMenu();
            break;
        case 3:
            // Editar Perro
            Console.WriteLine("Ingresa el Id del perro a editar: ");
            if (int.TryParse(Console.ReadLine(), out var dogIdToEdit))
            {
                veterinaryClinic.UpdateDog(veterinaryClinic.Dogs, dogIdToEdit);
            }
            else
            {
                Console.WriteLine("Id inválido. Intenta nuevamente.");
            }
            ManagerApp.StopMenu();
            break;
        case 4:
            // Eliminar Perro
            Console.WriteLine("Ingresa el Id del gato a eliminar: ");
            int idDeleteDog = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out var dogIdToDelete))
            {
                veterinaryClinic.DeleteDog(veterinaryClinic.Dogs, dogIdToDelete);
            }
            else
            {
                Console.WriteLine("Id inválido. Intenta nuevamente.");
            }
            ManagerApp.StopMenu();
            break;
        case 5:
            // Agregar Gato
            var newCat = ManagerApp.CreateCat();
            veterinaryClinic.SaveCat(newCat);
            ManagerApp.StopMenu();
            break;
        case 6:
            // Mostrar Gato
            veterinaryClinic.ShowAnimals("Gato");
            ManagerApp.StopMenu();
            break;
        case 7:
            // Editar Gato
            Console.WriteLine("Ingresa el Id del gato a editar: ");
            if (int.TryParse(Console.ReadLine(), out var catIdToEdit))
            {
                veterinaryClinic.UpdateCat(veterinaryClinic.Cats, catIdToEdit);
            }
            else
            {
                Console.WriteLine("Id inválido. Intenta nuevamente.");
            }
            ManagerApp.StopMenu();
            break;
        case 8:
            // Eliminar Gato
            Console.WriteLine("Ingresa el Id del gato a eliminar: ");
            int idDeleteCat = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out var catIdToDelete))
            {
                veterinaryClinic.DeleteCat(veterinaryClinic.Cats, catIdToDelete);
            }
            else
            {
                Console.WriteLine("Id inválido. Intenta nuevamente.");
            }
            ManagerApp.StopMenu();
            break;
        case 9:
            // Mostrar Pacientes
            veterinaryClinic.ShowAllPatients();
            ManagerApp.StopMenu();
            break;
        case 10:
            // Mostrar por Tipo
            Console.WriteLine("Igresa cuales mostrar (Perros o Gatos): ");
            string typeSearch = Console.ReadLine();
            veterinaryClinic.ShowAnimals(typeSearch);
            ManagerApp.StopMenu();
            break;
        case 11:
            // Buscar por Id
            Console.WriteLine("Igresa Id para buscar: ");
            int idSearch = Convert.ToInt32(Console.ReadLine());
            veterinaryClinic.ShowPatient(idSearch);
            ManagerApp.StopMenu();
            break;
        default:
            // Opción no válida
            Console.WriteLine("Opción inválida, intenta de nuevo");
            ManagerApp.StopMenu();
            break;
    }
}