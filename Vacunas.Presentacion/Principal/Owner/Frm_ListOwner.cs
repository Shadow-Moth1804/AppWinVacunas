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
    public partial class Frm_ListOwner : Form
    {
        OwnerCRUD con = new OwnerCRUD();
        private string OwnerName;
        public Frm_ListOwner()
        {
            InitializeComponent();
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {

        }

        private void dgv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loadinformation();
        }

        private void Frm_ListOwner_Load(object sender, EventArgs e)
        {
            con.LlenaGrid(dgv_List);
        }

        private void Loadinformation()
        {
            int fil = 0;
            fil= dgv_List.CurrentCell.RowIndex;
            OwnerName = Convert.ToString(dgv_List.Rows[fil].Cells[0].Value);
            con.Load(OwnerName, txt_Id, txt_Nombre,txt_telefono, txt_Email,txt_Observaciones);
        }
    }
}
