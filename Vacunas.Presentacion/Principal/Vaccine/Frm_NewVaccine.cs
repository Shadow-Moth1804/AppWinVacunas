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
    public partial class Frm_NewVaccine : Form
    {
        VaccineCRUD con = new VaccineCRUD();
        public Frm_NewVaccine()
        {
            InitializeComponent();
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "Escriba el nombre aqui")
            {
                if (txt_patogeno.Text != "Escriba patogeno aqui")
                {
                    con.NuevaVacuna(txt_name.Text, txt_patogeno.Text);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.Text="Escriba el nombre aqui";
            txt_patogeno.Text="Escriba patogeno aqui";
        }
    }
}
