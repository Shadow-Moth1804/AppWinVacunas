using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunas.Entity
{
    public class VacHistory
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public decimal PetWeight { get; set; }
        public string PetStage { get; set; }
        public int VacId { get; set; }
        public DateTime VacDate { get; set; }
        public int EmpId { get; set; }
        public string Observations { get; set; }
        public string PetName { get; set; }
        public string VacName { get; set; }
        public string EmpName { get; set; }
    }
}
