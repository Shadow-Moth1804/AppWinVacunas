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

namespace Vacunas.Presentacion.Principal.Pet
{
    public partial class Frm_RegHistory : Form
    {

        EmployeeCRUD emp = new EmployeeCRUD();
        VaccineCRUD vac = new VaccineCRUD();
        PetCRUD pet = new PetCRUD();
        VacHistoryCRUD hist = new VacHistoryCRUD();

        public Frm_RegHistory()
        {
            InitializeComponent();
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            hist.Registrar(cbo_name.Text,Convert.ToDouble(txt_peso.Text), txt_etapa.Text,cbo_vac.Text,dtp_date.Value, cbo_Emp.Text,txt_observaciones.Text);
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {

        }

        private void Frm_RegHistory_Load(object sender, EventArgs e)
        {
            emp.LLenaCombo(cbo_Emp);
            vac.LlenaCombo(cbo_vac);
            pet.LlenaCombo(cbo_name);
        }
    }
}
