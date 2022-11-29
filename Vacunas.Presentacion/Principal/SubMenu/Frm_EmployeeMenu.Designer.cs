namespace Vacunas.Presentacion.Principal
{
    partial class Frm_EmployeeMenu
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
            this.pnl_control = new System.Windows.Forms.Panel();
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.btn_newemp = new System.Windows.Forms.Button();
            this.btn_See = new System.Windows.Forms.Button();
            this.pnl_Child = new System.Windows.Forms.Panel();
            this.pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_control.Controls.Add(this.btn_NewUser);
            this.pnl_control.Controls.Add(this.btn_newemp);
            this.pnl_control.Controls.Add(this.btn_See);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(800, 25);
            this.pnl_control.TabIndex = 2;
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_NewUser.Location = new System.Drawing.Point(215, 0);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(97, 25);
            this.btn_NewUser.TabIndex = 2;
            this.btn_NewUser.Text = "Nuevo usuario";
            this.btn_NewUser.UseVisualStyleBackColor = true;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // btn_newemp
            // 
            this.btn_newemp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_newemp.Location = new System.Drawing.Point(118, 0);
            this.btn_newemp.Name = "btn_newemp";
            this.btn_newemp.Size = new System.Drawing.Size(97, 25);
            this.btn_newemp.TabIndex = 1;
            this.btn_newemp.Text = "Nuevo empleado";
            this.btn_newemp.UseVisualStyleBackColor = true;
            this.btn_newemp.Click += new System.EventHandler(this.btn_newemp_Click);
            // 
            // btn_See
            // 
            this.btn_See.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_See.Location = new System.Drawing.Point(0, 0);
            this.btn_See.Name = "btn_See";
            this.btn_See.Size = new System.Drawing.Size(118, 25);
            this.btn_See.TabIndex = 0;
            this.btn_See.Text = "Lista de empleados";
            this.btn_See.UseVisualStyleBackColor = true;
            this.btn_See.Click += new System.EventHandler(this.btn_See_Click);
            // 
            // pnl_Child
            // 
            this.pnl_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Child.Location = new System.Drawing.Point(0, 25);
            this.pnl_Child.Name = "pnl_Child";
            this.pnl_Child.Size = new System.Drawing.Size(800, 425);
            this.pnl_Child.TabIndex = 3;
            // 
            // Frm_EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Child);
            this.Controls.Add(this.pnl_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EmployeeMenu";
            this.Text = "Frm_Employee";
            this.pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Button btn_newemp;
        private System.Windows.Forms.Button btn_See;
        private System.Windows.Forms.Panel pnl_Child;
        private System.Windows.Forms.Button btn_NewUser;
    }
}