using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunas.Domain;

namespace Vacunas.Presentacion.Principal.Vaccine
{
    public partial class Frm_ListVaccine : Form
    {
        VaccineCRUD con = new VaccineCRUD();
        private string VacName;

        public Frm_ListVaccine()
        {
            InitializeComponent();
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            con.EliminarVac(Convert.ToInt32(txt_Id.Text));
        }

        private void dgv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loadinformation();
        }

        private void Loadinformation()
        {
            int fil = 0;
            fil= dgv_List.CurrentCell.RowIndex;
            VacName = Convert.ToString(dgv_List.Rows[fil].Cells[0].Value);
            con.LoadProfile(VacName, txt_Id, txt_Nombre, txt_Patogeno);
        }

        private void Frm_ListVaccine_Load(object sender, EventArgs e)
        {
            con.LlenaGrid(dgv_List);
        }
    }
}
