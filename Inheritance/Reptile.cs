using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Name = "Retiley";
            Age = 6;
            LegCount = 8;
        }
        public bool ColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat {  get; set; }
        public bool CanGrowTail { get; set; }
        
    }
}
