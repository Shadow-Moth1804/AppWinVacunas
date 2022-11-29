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
    public partial class Frm_NewUser : Form
    {
        UserCRUD user = new UserCRUD();
        EmployeeCRUD emp = new EmployeeCRUD();

        public Frm_NewUser()
        {
            InitializeComponent();
            emp.LLenaCombo(cbo_name);
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            user.NuevoUsuario(cbo_name.Text,txt_username.Text,txt_password.Text);
        }

        private void cbo_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp.Info(txt_range, cbo_name.Text);
        }
    }
}
