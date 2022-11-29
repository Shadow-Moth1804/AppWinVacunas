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
    public partial class Frm_ListPet : Form
    {
        PetCRUD con = new PetCRUD();
        private string PetName;
        public Frm_ListPet()
        {
            InitializeComponent();
        }
       

        private void dgv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loadinformation();
        }

        private void Frm_ListPet_Load(object sender, EventArgs e)
        {
            con.LlenaGrid(dgv_List);
            //Loadinformation();
        }
        private void Loadinformation()
        {
            int fil = 0;
            fil=dgv_List.CurrentCell.RowIndex;
            PetName = Convert.ToString(dgv_List.Rows[fil].Cells[0].Value);
            con.LoadProfile(PetName, txt_Id, txt_Nombre, txt_Raza, txt_Genero, txt_Fecha, txt_Dueño, txt_Observaciones);
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            con.EliminarMascota(Convert.ToInt32(txt_Id.Text));
        }
    }
}
