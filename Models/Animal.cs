using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

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
    }
}