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
    public partial class Frm_ListHistorial : Form
    {
        VacHistoryCRUD hist = new VacHistoryCRUD();
        PetCRUD pet = new PetCRUD();
        
        private string NamePet;

        public Frm_ListHistorial()
        {
            InitializeComponent();
        }

        private void Frm_ListHistorial_Load(object sender, EventArgs e)
        {
            pet.LlenaGrid(dgv_List);
        }
        private void Loadinformation()
        {
            int fil = 0;
            fil= dgv_List.CurrentCell.RowIndex;
            NamePet = Convert.ToString(dgv_List.Rows[fil].Cells[0].Value);
            hist.FLlenaGrid(NamePet,dgv_PetVac);
            //con.LoadProfile(NameVaccine, txt_Nombre, txt_peso, txt_etapa, txt_vacuna, txt_Fecha, txt_NomEmp, txt_observaciones);
           
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            hist.print(dataGridView1);
        }

        private void dgv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loadinformation();
        }
    }
   
}
