using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public abstract class Animal
    {
        // Se crea las propiedades de la clase Animal
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        // Constructor de la clase Animal
        public Animal(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Breed = breed;
            this.Color = color;
            this.WeightInKg = weightInKg;
        }

        // Métodos para obtener las propiedades de la clase Animal
        public string GetName() => Name;
        public DateOnly GetBirthDate() => BirthDate;
        public string GetBreed() => Breed;
        public string GetColor() => Color;
        public double GetWeightInKg() => WeightInKg;

        // Método para establecer los valores de las propiedades
        public void SetName(string value) => Name = value;
        public void SetBirthDate(DateOnly value) => BirthDate = value;
        public void SetBreed(string value) => Breed = value;
        public void SetColor(string value) => Color = value;
        public void SetWeightInKg(double value) => WeightInKg = value;

        // Método para mostrar la información (Abstract)
        public abstract void ShowInformacion();

        // Método para hacer una revisión básica
        public void BasicReview(){
            Console.WriteLine("Escribe tu review del animal: ");
            var review = Console.ReadLine();
            Console.WriteLine($"El animal {Name} presenta el siguiente review: {review}");
        }

        // Método para calcular la edad en meses
        public void CalculateAgeInMonth(int birthDate){
            int AgeInMonth= DateTime.Now.Month - BirthDate.Month;
            Console.WriteLine($"El animal {Name} tiene {AgeInMonth} meses.");
        }
    }
}