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

namespace Vacunas.Presentacion.Principal.Employee
{
    public partial class Frm_ListEmployee : Form
    {
        EmployeeCRUD con = new EmployeeCRUD();
        private string NameEmployee;
        public Frm_ListEmployee()
        {
            InitializeComponent();
        }

        private void Frm_ListEmployee_Load(object sender, EventArgs e)
        {
            con.LlenaGrid(dgv_ListEmployee);
            Loadinformation();
        }

        private void Loadinformation()
        {
            int fil = 0;
            fil= dgv_ListEmployee.CurrentCell.RowIndex;
            NameEmployee = Convert.ToString(dgv_ListEmployee.Rows[fil].Cells[0].Value);
            con.LoadProfile(NameEmployee,txt_Id, txt_Nombre, txt_Rango, txt_Email);
        }

        private void dgv_ListEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loadinformation();
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            con.EliminarEmpleado(Convert.ToInt32(txt_Id.Text));
        }
    }
}
