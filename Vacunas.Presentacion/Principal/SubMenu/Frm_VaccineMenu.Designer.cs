namespace Vacunas.Presentacion.Principal
{
    partial class Frm_VaccineMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_Child = new System.Windows.Forms.Panel();
            this.pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_control.Controls.Add(this.button2);
            this.pnl_control.Controls.Add(this.button1);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control.Location = new System.Drawing.Point(0, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(800, 25);
            this.pnl_control.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(118, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nueva vacuna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lista de vacunas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_Child
            // 
            this.pnl_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Child.Location = new System.Drawing.Point(0, 25);
            this.pnl_Child.Name = "pnl_Child";
            this.pnl_Child.Size = new System.Drawing.Size(800, 425);
            this.pnl_Child.TabIndex = 2;
            // 
            // Frm_VaccineMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Child);
            this.Controls.Add(this.pnl_control);
            this.Name = "Frm_VaccineMenu";
            this.Text = "Frm_VaccineMenu";
            this.pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_Child;
    }
}