using System;
using System.Drawing;
using System.Windows.Forms;
using Vacunas.Domain;

namespace Vacunas.Presentacion.Principal.Employee
{
    public partial class Frm_NewEmployee : Form
    {
        EmployeeCRUD con = new EmployeeCRUD();

        public Frm_NewEmployee()
        {
            InitializeComponent();
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "Escriba el nombre aqui")
            {
                if (txt_range.Text != "Escriba rango aqui")
                {
                    if (txt_email.Text != "Escriba el correo aqui")
                    {
                        con.NuevoEmpleado(txt_name.Text, txt_range.Text, txt_email.Text);
                    }
                    else { MsgError("El campo correo es necesario"); txt_email.Focus(); }
                }
                else { MsgError("El campo rango es necesario"); txt_range.Focus(); }
            }
            else { MsgError("El campo nombre es necesario"); txt_name.Focus(); }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals("Escriba el nombre aqui"))
            {
                txt_name.Text="";
                txt_name.ForeColor=Color.Black;
            }
        }

        private void txt_range_Enter(object sender, EventArgs e)
        {
            if (txt_range.Text.Equals("Escriba rango aqui"))
            {
                txt_range.Text="";
                txt_range.ForeColor=Color.Black;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals("Escriba el correo aqui"))
            {
                txt_email.Text="";
                txt_email.ForeColor=Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                txt_name.Text="Escriba el nombre aqui";
                txt_name.ForeColor= Color.Gray;
            }
        }

        private void txt_range_Leave(object sender, EventArgs e)
        {
            if (txt_range.Text.Equals(""))
            {
                txt_range.Text="Escriba rango aqui";
                txt_range.ForeColor= Color.Gray;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals(""))
            {
                txt_email.Text="Escriba el correo aqui";
                txt_email.ForeColor= Color.Gray;
            }
        }

        private void MsgError(string msg)
        {
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}