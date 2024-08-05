using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltroCSharp_CamiloBarreneche.Models
{
    public class Cat : Animal
    {
        // Se crean las propiedades de la clase Cat
        public bool BreedingStatus { get; set; }
        public string FurLenght { get; set; }
    }
}