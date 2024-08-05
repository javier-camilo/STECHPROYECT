namespace STECHPROYECT
{
    partial class FrmMatriculas
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelVer = new System.Windows.Forms.Panel();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(328, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Matricular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelVer
            // 
            this.panelVer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVer.Location = new System.Drawing.Point(430, 0);
            this.panelVer.Name = "panelVer";
            this.panelVer.Size = new System.Drawing.Size(870, 544);
            this.panelVer.TabIndex = 1;
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMatriculados.Location = new System.Drawing.Point(23, 36);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.Size = new System.Drawing.Size(391, 455);
            this.dgvMatriculados.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificación";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Grado";
            this.Column3.Name = "Column3";
            // 
            // FrmMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 544);
            this.Controls.Add(this.dgvMatriculados);
            this.Controls.Add(this.panelVer);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatriculas";
            this.Text = "FrmOtros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelVer;
        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}