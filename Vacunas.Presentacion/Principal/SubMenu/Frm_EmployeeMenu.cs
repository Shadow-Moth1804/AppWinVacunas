using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunas.Presentacion.Principal.Employee;

namespace Vacunas.Presentacion.Principal
{

    public partial class Frm_EmployeeMenu : Form
    {

        #region ChildForm
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            pnl_Child.Controls.Add(childForm);
            pnl_Child.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        public Frm_EmployeeMenu()
        {
            InitializeComponent();
            OpenChildForm(new Frm_ListEmployee());
        }

        private void btn_newemp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NewEmployee());
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NewUser());
        }

        private void btn_See_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ListEmployee());
        }
    }
}
