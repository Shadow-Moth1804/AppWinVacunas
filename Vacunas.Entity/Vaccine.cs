using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunas.Entity
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string VacName { get; set; }
        public string Pathogen { get; set; }
        public bool Condition { get; set; } 
    }
}
