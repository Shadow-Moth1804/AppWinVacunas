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

namespace Vacunas.Presentacion.Principal.Owner
{
    public partial class Frm_NewOwner : Form
    {
        OwnerCRUD con = new OwnerCRUD();
        public Frm_NewOwner()
        {
            InitializeComponent();
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            con.NuevoDueño(txt_Nombre.Text,txt_telefono.Text,txt_Email.Text,txt_Observaciones.Text);
            MessageBox.Show("Se agrego un nuevo dueño");
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text="Escribe nombre";
            txt_telefono.Text="Escribe telefono";
            txt_Email.Text="Escribe emai";
            txt_Observaciones.Text="";
        }
    }
}
