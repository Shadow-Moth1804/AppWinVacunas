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
    public partial class Frm_NewPet : Form
    {
        PetCRUD con = new PetCRUD();
        OwnerCRUD own = new OwnerCRUD();
        public Frm_NewPet()
        {
            InitializeComponent();
            own.LlenaCombo(comboBox1);
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            con.NuevaMascota(txt_Nombre.Text,txt_raza.Text,txt_genero.Text,dtp_date.Value,txt_observaciones.Text, comboBox1.Text);
            MessageBox.Show("Se registro una nueva mascota");
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text="ESCRIBE NOMBRE";
            txt_genero.Text="ESCRIBE GENERO";
            txt_raza.Text="ESCRIBE RAZA";
            txt_observaciones.Text="";
            dtp_date.Value = DateTime.Today;
        }

    }
}
