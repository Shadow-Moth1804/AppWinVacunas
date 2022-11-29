using System;
using System.Drawing;
using System.Windows.Forms;
using Vacunas.Presentacion.Principal;
using Vacunas.Domain;

namespace Vacunas.Presentacion.Inicio
{
    public partial class Frm_Login : Form
    {
        UserCRUD con = new UserCRUD();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text != "Usuario")
                {
                    if (txt_password.Text !="Contraseña")
                    {
                        if (con.Login(txt_user.Text, txt_password.Text)==true)
                        {
                            Frm_Principal menu = new Frm_Principal();
                            menu.Show();
                            menu.FormClosed += reload;
                            this.Hide();

                        }
                        else MsgError("Incorrect UserName or Password try again"); txt_user.Text ="Usuario"; txt_password.Text="Contraseña";
                    }
                    else MsgError("Please enter Password"); txt_password.Focus();
                }
                else MsgError("Please enter UserName"); txt_user.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text.Equals(""))
            {
                txt_user.Text="Usuario";
                txt_user.ForeColor= Color.Gray;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals(""))
            {
                txt_password.Text="Contraseña";
                txt_password.ForeColor= Color.Gray;
                txt_password.UseSystemPasswordChar= false;
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text.Equals("Usuario"))
            {
                txt_user.Text="";
                txt_user.ForeColor=Color.Black;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals("Contraseña"))
            {
                txt_password.Text = "";
                txt_password.ForeColor=Color.Black;
                txt_password.UseSystemPasswordChar= true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void MsgError(string msg)
        {
            MessageBox.Show(msg);
        }

        private void reload(object sender, FormClosedEventArgs e)
        {
            txt_user.Text="Usuario";
            txt_password.Text="Contraseña";
            this.Show();
        }
    }
}