namespace Vacunas.Presentacion.Principal.Pet
{
    partial class Frm_ListPet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.ListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_raza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Raza = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_dell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_Dueño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "LISTA DE MASCOTAS";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.AllowUserToDeleteRows = false;
            this.dgv_List.AllowUserToResizeColumns = false;
            this.dgv_List.AllowUserToResizeRows = false;
            this.dgv_List.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListID});
            this.dgv_List.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_List.EnableHeadersVisualStyles = false;
            this.dgv_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.dgv_List.Location = new System.Drawing.Point(0, 23);
            this.dgv_List.MultiSelect = false;
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_List.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_List.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_List.Size = new System.Drawing.Size(146, 427);
            this.dgv_List.TabIndex = 19;
            this.dgv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_List_CellContentClick);
            // 
            // ListID
            // 
            this.ListID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ListID.HeaderText = "NOMBRE";
            this.ListID.Name = "ListID";
            this.ListID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_raza, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Raza, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nombre, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_genero, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txt_Fecha, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_Dueño, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txt_Observaciones, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.txt_Genero, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(146, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 427);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_raza
            // 
            this.lbl_raza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_raza.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_raza.Location = new System.Drawing.Point(3, 96);
            this.lbl_raza.Name = "lbl_raza";
            this.lbl_raza.Size = new System.Drawing.Size(321, 24);
            this.lbl_raza.TabIndex = 4;
            this.lbl_raza.Text = "RAZA";
            this.lbl_raza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Raza
            // 
            this.txt_Raza.BackColor = System.Drawing.Color.White;
            this.txt_Raza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Raza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Raza.Enabled = false;
            this.txt_Raza.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Raza.Location = new System.Drawing.Point(327, 120);
            this.txt_Raza.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Raza.Name = "txt_Raza";
            this.txt_Raza.ReadOnly = true;
            this.txt_Raza.Size = new System.Drawing.Size(327, 24);
            this.txt_Raza.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.White;
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(327, 72);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(327, 24);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.White;
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(327, 24);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(327, 24);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_genero.Location = new System.Drawing.Point(3, 144);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(321, 24);
            this.lbl_genero.TabIndex = 10;
            this.lbl_genero.Text = "GENERO";
            this.lbl_genero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "FECHA  DE NACIMIENTO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_dell, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(327, 397);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 30);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btn_dell
            // 
            this.btn_dell.BackColor = System.Drawing.Color.LightCoral;
            this.btn_dell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dell.FlatAppearance.BorderSize = 0;
            this.btn_dell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dell.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dell.Location = new System.Drawing.Point(166, 3);
            this.btn_dell.Name = "btn_dell";
            this.btn_dell.Size = new System.Drawing.Size(158, 24);
            this.btn_dell.TabIndex = 8;
            this.btn_dell.Text = "ELIMINAR";
            this.btn_dell.UseVisualStyleBackColor = false;
            this.btn_dell.Click += new System.EventHandler(this.btn_dell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "DUEÑO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.White;
            this.txt_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_Fecha.Location = new System.Drawing.Point(330, 219);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(321, 24);
            this.txt_Fecha.TabIndex = 13;
            // 
            // txt_Dueño
            // 
            this.txt_Dueño.BackColor = System.Drawing.Color.White;
            this.txt_Dueño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dueño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Dueño.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_Dueño.Location = new System.Drawing.Point(330, 267);
            this.txt_Dueño.Name = "txt_Dueño";
            this.txt_Dueño.ReadOnly = true;
            this.txt_Dueño.Size = new System.Drawing.Size(321, 24);
            this.txt_Dueño.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(3, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "OBSERVACIONES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.BackColor = System.Drawing.Color.White;
            this.txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Observaciones.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_Observaciones.Location = new System.Drawing.Point(330, 315);
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.ReadOnly = true;
            this.txt_Observaciones.Size = new System.Drawing.Size(321, 24);
            this.txt_Observaciones.TabIndex = 16;
            // 
            // txt_Genero
            // 
            this.txt_Genero.BackColor = System.Drawing.Color.White;
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Genero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Genero.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txt_Genero.Location = new System.Drawing.Point(330, 171);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.ReadOnly = true;
            this.txt_Genero.Size = new System.Drawing.Size(321, 24);
            this.txt_Genero.TabIndex = 17;
            // 
            // Frm_ListPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv_List);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListPet";
            this.Text = "Frm_ListPet";
            this.Load += new System.EventHandler(this.Frm_ListPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_raza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Raza;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_dell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_Dueño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.TextBox txt_Genero;
    }
}