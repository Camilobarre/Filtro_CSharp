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
    }
}