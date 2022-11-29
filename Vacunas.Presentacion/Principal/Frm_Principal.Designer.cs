namespace Vacunas.Presentacion.Principal
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_control = new System.Windows.Forms.Panel();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Vaccine = new System.Windows.Forms.Button();
            this.btn_Pet = new System.Windows.Forms.Button();
            this.btn_Owner = new System.Windows.Forms.Button();
            this.pnl_Child = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_control.Controls.Add(this.btn_Employee);
            this.pnl_control.Controls.Add(this.btn_Vaccine);
            this.pnl_control.Controls.Add(this.btn_Pet);
            this.pnl_control.Controls.Add(this.btn_Owner);
            this.pnl_control.Controls.Add(this.pictureBox1);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(200, 453);
            this.pnl_control.TabIndex = 0;
            // 
            // btn_Employee
            // 
            this.btn_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Employee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.Location = new System.Drawing.Point(0, 220);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(200, 40);
            this.btn_Employee.TabIndex = 4;
            this.btn_Employee.Text = "Empleados";
            this.btn_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Vaccine
            // 
            this.btn_Vaccine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Vaccine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vaccine.Location = new System.Drawing.Point(0, 180);
            this.btn_Vaccine.Name = "btn_Vaccine";
            this.btn_Vaccine.Size = new System.Drawing.Size(200, 40);
            this.btn_Vaccine.TabIndex = 3;
            this.btn_Vaccine.Text = "Vacunas";
            this.btn_Vaccine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vaccine.UseVisualStyleBackColor = true;
            this.btn_Vaccine.Click += new System.EventHandler(this.btn_Vaccine_Click);
            // 
            // btn_Pet
            // 
            this.btn_Pet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pet.Location = new System.Drawing.Point(0, 140);
            this.btn_Pet.Name = "btn_Pet";
            this.btn_Pet.Size = new System.Drawing.Size(200, 40);
            this.btn_Pet.TabIndex = 2;
            this.btn_Pet.Text = "Mascotas";
            this.btn_Pet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pet.UseVisualStyleBackColor = true;
            this.btn_Pet.Click += new System.EventHandler(this.btn_Pet_Click);
            // 
            // btn_Owner
            // 
            this.btn_Owner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Owner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Owner.Location = new System.Drawing.Point(0, 100);
            this.btn_Owner.Name = "btn_Owner";
            this.btn_Owner.Size = new System.Drawing.Size(200, 40);
            this.btn_Owner.TabIndex = 1;
            this.btn_Owner.Text = "Dueños";
            this.btn_Owner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Owner.UseVisualStyleBackColor = true;
            this.btn_Owner.Click += new System.EventHandler(this.btn_Owner_Click);
            // 
            // pnl_Child
            // 
            this.pnl_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Child.Location = new System.Drawing.Point(200, 0);
            this.pnl_Child.Name = "pnl_Child";
            this.pnl_Child.Size = new System.Drawing.Size(501, 453);
            this.pnl_Child.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 453);
            this.Controls.Add(this.pnl_Child);
            this.Controls.Add(this.pnl_control);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.pnl_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Panel pnl_Child;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_Vaccine;
        private System.Windows.Forms.Button btn_Pet;
        private System.Windows.Forms.Button btn_Owner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



