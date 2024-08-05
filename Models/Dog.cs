using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class Dog : Animal
    {
        // Se crean las propiedades de la clase Dog
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

    }
}