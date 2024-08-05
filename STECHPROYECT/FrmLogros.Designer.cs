namespace STECHPROYECT
{
    partial class FrmLogros
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
            this.dgvLogro = new System.Windows.Forms.DataGridView();
            this.CmbMateria = new System.Windows.Forms.ComboBox();
            this.CmbCalificacion = new System.Windows.Forms.ComboBox();
            this.TxtLogro = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CmbGrado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogro
            // 
            this.dgvLogro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLogro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogro.Location = new System.Drawing.Point(308, 10);
            this.dgvLogro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLogro.Name = "dgvLogro";
            this.dgvLogro.RowTemplate.Height = 24;
            this.dgvLogro.Size = new System.Drawing.Size(483, 387);
            this.dgvLogro.TabIndex = 0;
            this.dgvLogro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogro_CellContentClick);
            // 
            // CmbMateria
            // 
            this.CmbMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbMateria.BackColor = System.Drawing.Color.White;
            this.CmbMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMateria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbMateria.ForeColor = System.Drawing.Color.Black;
            this.CmbMateria.FormattingEnabled = true;
            this.CmbMateria.ItemHeight = 20;
            this.CmbMateria.Location = new System.Drawing.Point(21, 48);
            this.CmbMateria.Name = "CmbMateria";
            this.CmbMateria.Size = new System.Drawing.Size(266, 28);
            this.CmbMateria.TabIndex = 2;
            // 
            // CmbCalificacion
            // 
            this.CmbCalificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbCalificacion.FormattingEnabled = true;
            this.CmbCalificacion.Items.AddRange(new object[] {
            "SUPERIOR",
            "ALTO",
            "BASICO",
            "BAJO"});
            this.CmbCalificacion.Location = new System.Drawing.Point(20, 86);
            this.CmbCalificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCalificacion.Name = "CmbCalificacion";
            this.CmbCalificacion.Size = new System.Drawing.Size(266, 28);
            this.CmbCalificacion.TabIndex = 3;
            // 
            // TxtLogro
            // 
            this.TxtLogro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtLogro.Location = new System.Drawing.Point(20, 124);
            this.TxtLogro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLogro.Multiline = true;
            this.TxtLogro.Name = "TxtLogro";
            this.TxtLogro.Size = new System.Drawing.Size(267, 273);
            this.TxtLogro.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.Location = new System.Drawing.Point(37, 402);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(232, 33);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.Location = new System.Drawing.Point(308, 402);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(232, 33);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(560, 402);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(232, 33);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // CmbGrado
            // 
            this.CmbGrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbGrado.BackColor = System.Drawing.Color.White;
            this.CmbGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGrado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbGrado.ForeColor = System.Drawing.Color.Black;
            this.CmbGrado.FormattingEnabled = true;
            this.CmbGrado.Items.AddRange(new object[] {
            "PRE-JARDIN",
            "JARDIN",
            "TRANSICIÓN",
            "PRIMERO ",
            "SEGUNDO",
            "TERCERO"});
            this.CmbGrado.Location = new System.Drawing.Point(21, 10);
            this.CmbGrado.Name = "CmbGrado";
            this.CmbGrado.Size = new System.Drawing.Size(266, 28);
            this.CmbGrado.TabIndex = 8;
            this.CmbGrado.SelectedIndexChanged += new System.EventHandler(this.CmbGrado_SelectedIndexChanged);
            // 
            // FrmLogros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbGrado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtLogro);
            this.Controls.Add(this.CmbCalificacion);
            this.Controls.Add(this.CmbMateria);
            this.Controls.Add(this.dgvLogro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogros";
            this.Text = "FrmLogros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogro;
        private System.Windows.Forms.ComboBox CmbMateria;
        private System.Windows.Forms.ComboBox CmbCalificacion;
        private System.Windows.Forms.TextBox TxtLogro;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox CmbGrado;
    }
}