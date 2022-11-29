namespace Vacunas.Presentacion.Principal.Vaccine
{
    partial class Frm_NewVaccine
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_range = new System.Windows.Forms.Label();
            this.txt_patogeno = new System.Windows.Forms.TextBox();
            this.tlp_Control = new System.Windows.Forms.TableLayoutPanel();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
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
            this.lbl_title.Text = "REGISTRO NUEVA VACUNA";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlp_Body
            // 
            this.tlp_Body.ColumnCount = 2;
            this.tlp_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Body.Controls.Add(this.lbl_name, 0, 0);
            this.tlp_Body.Controls.Add(this.txt_name, 1, 1);
            this.tlp_Body.Controls.Add(this.lbl_range, 0, 2);
            this.tlp_Body.Controls.Add(this.txt_patogeno, 1, 3);
            this.tlp_Body.Controls.Add(this.tlp_Control, 1, 7);
            this.tlp_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Body.Location = new System.Drawing.Point(0, 23);
            this.tlp_Body.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Body.Name = "tlp_Body";
            this.tlp_Body.RowCount = 8;
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
            this.lbl_name.Size = new System.Drawing.Size(114, 40);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "NOMBRE:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Gray;
            this.txt_name.Location = new System.Drawing.Point(120, 40);
            this.txt_name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(680, 24);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Escriba el nombre aqui";
            // 
            // lbl_range
            // 
            this.lbl_range.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_range.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_range.Location = new System.Drawing.Point(3, 64);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(114, 40);
            this.lbl_range.TabIndex = 2;
            this.lbl_range.Text = "PATOGENO:";
            this.lbl_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_patogeno
            // 
            this.txt_patogeno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_patogeno.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patogeno.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_patogeno.ForeColor = System.Drawing.Color.Gray;
            this.txt_patogeno.Location = new System.Drawing.Point(120, 104);
            this.txt_patogeno.Margin = new System.Windows.Forms.Padding(0);
            this.txt_patogeno.Name = "txt_patogeno";
            this.txt_patogeno.Size = new System.Drawing.Size(680, 24);
            this.txt_patogeno.TabIndex = 3;
            this.txt_patogeno.Text = "Escriba patogeno aqui";
            // 
            // tlp_Control
            // 
            this.tlp_Control.ColumnCount = 2;
            this.tlp_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Control.Controls.Add(this.btn_acept, 0, 0);
            this.tlp_Control.Controls.Add(this.btn_cancel, 1, 0);
            this.tlp_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Control.Location = new System.Drawing.Point(120, 397);
            this.tlp_Control.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Control.Name = "tlp_Control";
            this.tlp_Control.RowCount = 1;
            this.tlp_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Control.Size = new System.Drawing.Size(680, 30);
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
            this.btn_acept.Size = new System.Drawing.Size(334, 24);
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
            this.btn_cancel.Location = new System.Drawing.Point(343, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(334, 24);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Frm_NewVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_Body);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NewVaccine";
            this.Text = "Frm_NewVaccine";
            this.tlp_Body.ResumeLayout(false);
            this.tlp_Body.PerformLayout();
            this.tlp_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tlp_Body;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.TextBox txt_patogeno;
        private System.Windows.Forms.TableLayoutPanel tlp_Control;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancel;
    }
}