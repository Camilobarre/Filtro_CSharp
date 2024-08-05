using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public abstract class Animal
    {
        //se crean atributos protegidos
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        //constructor de la clase

        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        // Método para mostrar información de la mascota
        public abstract void ShowInformacion();

        // Mostrar información breve de la mascota
        protected void BasicReview()
        {
            Console.WriteLine("Ingresa una descripcion breve de como ingresó su mascota a la veterinaria");
            string review = Console.ReadLine();

            Console.WriteLine($"La descripcion de la mascota al ingresar a la veterinaria: {review}");

        }
        // Calcular la edad en meses
        protected int CalculateAgeInMonths()
        {
            DateTime CurrentDate = DateTime.Now;
            int age = (CurrentDate.Year - Birthdate.Year) * 12 + CurrentDate.Month - CurrentDate.Month;
            return age;
        }

        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }

        public double GetWeightInKg()
        {
            return WeightInKg;
        }
        public void SetNombre(string nuevoNombre)
        {
            Name = nuevoNombre;
        }
        public void SetWeightInKg(double weightInKg)
        {
            WeightInKg = weightInKg;
        }
    }
}