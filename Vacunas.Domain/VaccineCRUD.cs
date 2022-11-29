using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunas.DataAccess;
using Vacunas.Entity;

namespace Vacunas.Domain
{
    public class VaccineCRUD
    {
        ConexionDataContext conexion = new ConexionDataContext();

        public List<Vaccine> Vaccine()
        {
            var list = from E in conexion.sp_ListVac()
                       select new Vaccine
                       {
                           Id = E.Id,
                           VacName = E.VacName,
                           Pathogen = E.Pathogen,
                           Condition = (bool)E.Condition
                       };
            return list.ToList();
        }

        public void NuevaVacuna(string name, string pathogen)
        {
            conexion.sp_NewVaccine(name, pathogen);
            conexion.SubmitChanges();
        }

        public void LlenaGrid(DataGridView dgv)
        {
            foreach (var list in Vaccine())
            {
                dgv.Rows.Add(list.VacName);
            }
        }

        public void LoadProfile(string name, TextBox Id, TextBox Name, TextBox Patogeno)
        {
            try
            {
                foreach (var list in Vaccine())
                {
                    if (list.VacName.Equals(name))
                    {
                        Id.Text=list.Id.ToString();
                        Name.Text=list.VacName;
                        Patogeno.Text=list.Pathogen;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarVac(int Id)
        {
            conexion.sp_DelVac(Id);
        }

        public void LlenaCombo(ComboBox cbo)
        {
            cbo.DataSource = Vaccine();
            cbo.ValueMember="Id";
            cbo.DisplayMember="VacName";
        }
    }
}
