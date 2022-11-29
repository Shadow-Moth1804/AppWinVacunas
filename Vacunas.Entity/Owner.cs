using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunas.Entity
{
    public class Owner
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AdData { get; set; }
        public bool Condition { get; set; }
    }
}
