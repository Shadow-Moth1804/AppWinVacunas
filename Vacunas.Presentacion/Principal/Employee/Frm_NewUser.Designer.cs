namespace Vacunas.Presentacion.Principal.Employee
{
    partial class Frm_NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.tlp_Body = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_range = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_Control = new System.Windows.Forms.TableLayoutPanel();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_range = new System.Windows.Forms.TextBox();
            this.tlp_Body.SuspendLayout();
            this.tlp_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(800, 23);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "REGISTRO NUEVO USUARIO";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlp_Body
            // 
            this.tlp_Body.ColumnCount = 2;
            this.tlp_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlp_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Body.Controls.Add(this.lbl_name, 0, 0);
            this.tlp_Body.Controls.Add(this.lbl_range, 0, 2);
            this.tlp_Body.Controls.Add(this.lbl_email, 0, 4);
            this.tlp_Body.Controls.Add(this.txt_username, 1, 5);
            this.tlp_Body.Controls.Add(this.cbo_name, 1, 1);
            this.tlp_Body.Controls.Add(this.label1, 0, 6);
            this.tlp_Body.Controls.Add(this.tlp_Control, 1, 9);
            this.tlp_Body.Controls.Add(this.txt_password, 1, 7);
            this.tlp_Body.Controls.Add(this.txt_range, 1, 3);
            this.tlp_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Body.Location = new System.Drawing.Point(0, 23);
            this.tlp_Body.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Body.Name = "tlp_Body";
            this.tlp_Body.RowCount = 10;
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Body.Size = new System.Drawing.Size(800, 427);
            this.tlp_Body.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(224, 40);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "NOMBRE DE EMPLEADO:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_range
            // 
            this.lbl_range.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_range.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_range.Location = new System.Drawing.Point(3, 64);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(224, 40);
            this.lbl_range.TabIndex = 2;
            this.lbl_range.Text = "RANGO:";
            this.lbl_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_email.Location = new System.Drawing.Point(3, 128);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(224, 40);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "User Name:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_username.ForeColor = System.Drawing.Color.Gray;
            this.txt_username.Location = new System.Drawing.Point(230, 168);
            this.txt_username.Margin = new System.Windows.Forms.Padding(0);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(570, 24);
            this.txt_username.TabIndex = 4;
            this.txt_username.Text = "Escribe el usuario aqui";
            // 
            // cbo_name
            // 
            this.cbo_name.BackColor = System.Drawing.Color.White;
            this.cbo_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(233, 43);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(564, 30);
            this.cbo_name.TabIndex = 7;
            this.cbo_name.SelectedIndexChanged += new System.EventHandler(this.cbo_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Control
            // 
            this.tlp_Control.ColumnCount = 2;
            this.tlp_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50774F));
            this.tlp_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49226F));
            this.tlp_Control.Controls.Add(this.btn_acept, 0, 0);
            this.tlp_Control.Controls.Add(this.btn_cancel, 1, 0);
            this.tlp_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Control.Location = new System.Drawing.Point(230, 397);
            this.tlp_Control.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Control.Name = "tlp_Control";
            this.tlp_Control.RowCount = 1;
            this.tlp_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Control.Size = new System.Drawing.Size(570, 30);
            this.tlp_Control.TabIndex = 6;
            // 
            // btn_acept
            // 
            this.btn_acept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(204)))));
            this.btn_acept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_acept.FlatAppearance.BorderSize = 0;
            this.btn_acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acept.Location = new System.Drawing.Point(3, 3);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(276, 24);
            this.btn_acept.TabIndex = 0;
            this.btn_acept.Text = "ACEPTAR";
            this.btn_acept.UseVisualStyleBackColor = false;
            this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(285, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(282, 24);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(230, 232);
            this.txt_password.Margin = new System.Windows.Forms.Padding(0);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(570, 24);
            this.txt_password.TabIndex = 9;
            this.txt_password.Text = "Escribe la contraseña aqui";
            // 
            // txt_range
            // 
            this.txt_range.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_range.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_range.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_range.ForeColor = System.Drawing.Color.Gray;
            this.txt_range.Location = new System.Drawing.Point(230, 104);
            this.txt_range.Margin = new System.Windows.Forms.Padding(0);
            this.txt_range.Name = "txt_range";
            this.txt_range.ReadOnly = true;
            this.txt_range.Size = new System.Drawing.Size(570, 24);
            this.txt_range.TabIndex = 3;
            // 
            // Frm_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_Body);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NewUser";
            this.Text = "Frm_NewUser";
            this.tlp_Body.ResumeLayout(false);
            this.tlp_Body.PerformLayout();
            this.tlp_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tlp_Body;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_range;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TableLayoutPanel tlp_Control;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
    }
}