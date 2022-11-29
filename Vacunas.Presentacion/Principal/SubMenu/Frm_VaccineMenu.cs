using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunas.Presentacion.Principal.Vaccine;

namespace Vacunas.Presentacion.Principal
{
    public partial class Frm_VaccineMenu : Form
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
        public Frm_VaccineMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NewVaccine());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ListVaccine());
        }
    }
}
