namespace STECHPROYECT
{
    partial class FrmMaterias
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
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGrado
            // 
            this.comboGrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboGrado.BackColor = System.Drawing.Color.White;
            this.comboGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboGrado.ForeColor = System.Drawing.Color.Black;
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Items.AddRange(new object[] {
            "PRE-JARDIN",
            "JARDIN",
            "TRANSICIÓN",
            "PRIMERO ",
            "SEGUNDO",
            "TERCERO"});
            this.comboGrado.Location = new System.Drawing.Point(41, 191);
            this.comboGrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(308, 33);
            this.comboGrado.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(41, 274);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(309, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Maeria";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.Location = new System.Drawing.Point(41, 233);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMateria.Multiline = true;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(307, 34);
            this.txtMateria.TabIndex = 3;
            this.txtMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(407, 15);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(644, 476);
            this.dgvMaterias.TabIndex = 4;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            this.dgvMaterias.DoubleClick += new System.EventHandler(this.dgvMaterias_DoubleClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.Location = new System.Drawing.Point(407, 498);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(309, 41);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "Editar Maeria";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(741, 498);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(309, 41);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Quitar Maeria";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboGrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMaterias";
            this.Text = "FrmMaterias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}