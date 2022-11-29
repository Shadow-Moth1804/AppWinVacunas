using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunas.Entity
{
    public class Pet
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public DateTime DateBirth { get; set; }
        public string AdData { get; set; }
        public int OwnerId { get; set; }
        public bool Condition { get; set; }
        public string OwnerName { get; set; }
    }
}
