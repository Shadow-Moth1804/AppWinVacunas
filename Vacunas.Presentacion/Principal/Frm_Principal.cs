using System;
using System.Windows.Forms;

namespace Vacunas.Presentacion.Principal
{
    public partial class Frm_Principal : Form
    {

        public Frm_Principal()
        {
            InitializeComponent();
        }

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

        private void btn_Owner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_OwnerMenu());
        }

        private void btn_Pet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_PetMenu());
        }

        private void btn_Vaccine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_VaccineMenu());
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_EmployeeMenu());
        }
    }
}
