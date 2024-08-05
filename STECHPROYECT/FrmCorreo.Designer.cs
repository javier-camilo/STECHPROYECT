namespace STECHPROYECT
{
    partial class FrmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreo));
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.pnlRedactar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarRedactar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRedactar = new System.Windows.Forms.Button();
            this.pnlRedactar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(381, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 30);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Location = new System.Drawing.Point(4, 333);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 29);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(4, 309);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(374, 20);
            this.txtRuta.TabIndex = 15;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.FlatAppearance.BorderSize = 0;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Roboto Bk", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.ForeColor = System.Drawing.Color.Black;
            this.btnAdjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntar.Image")));
            this.btnAdjuntar.Location = new System.Drawing.Point(80, 335);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(23, 26);
            this.btnAdjuntar.TabIndex = 3;
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // txtBody
            // 
            this.txtBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBody.Location = new System.Drawing.Point(4, 99);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(403, 204);
            this.txtBody.TabIndex = 2;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsunto.Location = new System.Drawing.Point(5, 76);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(403, 13);
            this.txtAsunto.TabIndex = 1;
            this.txtAsunto.Text = "Asunto";
            this.txtAsunto.Enter += new System.EventHandler(this.txtAsunto_Enter);
            this.txtAsunto.Leave += new System.EventHandler(this.txtAsunto_Leave);
            // 
            // txtPara
            // 
            this.txtPara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPara.BackColor = System.Drawing.Color.White;
            this.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPara.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(4, 47);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(403, 14);
            this.txtPara.TabIndex = 0;
            this.txtPara.Text = "Para:";
            this.txtPara.Enter += new System.EventHandler(this.txtPara_Enter);
            this.txtPara.Leave += new System.EventHandler(this.txtPara_Leave);
            // 
            // pnlRedactar
            // 
            this.pnlRedactar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRedactar.BackColor = System.Drawing.Color.White;
            this.pnlRedactar.Controls.Add(this.button4);
            this.pnlRedactar.Controls.Add(this.button2);
            this.pnlRedactar.Controls.Add(this.button3);
            this.pnlRedactar.Controls.Add(this.panel2);
            this.pnlRedactar.Controls.Add(this.txtBody);
            this.pnlRedactar.Controls.Add(this.panel4);
            this.pnlRedactar.Controls.Add(this.txtRuta);
            this.pnlRedactar.Controls.Add(this.txtPara);
            this.pnlRedactar.Controls.Add(this.btnEnviar);
            this.pnlRedactar.Controls.Add(this.btnAdjuntar);
            this.pnlRedactar.Controls.Add(this.panel3);
            this.pnlRedactar.Controls.Add(this.txtAsunto);
            this.pnlRedactar.Controls.Add(this.button1);
            this.pnlRedactar.Location = new System.Drawing.Point(240, 0);
            this.pnlRedactar.Name = "pnlRedactar";
            this.pnlRedactar.Size = new System.Drawing.Size(411, 366);
            this.pnlRedactar.TabIndex = 22;
            this.pnlRedactar.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Bk", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(140, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 26);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Bk", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(108, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto Bk", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(382, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 26);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.btnCerrarRedactar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 39);
            this.panel2.TabIndex = 0;
            // 
            // btnCerrarRedactar
            // 
            this.btnCerrarRedactar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarRedactar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRedactar.FlatAppearance.BorderSize = 0;
            this.btnCerrarRedactar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRedactar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRedactar.Image")));
            this.btnCerrarRedactar.Location = new System.Drawing.Point(371, 3);
            this.btnCerrarRedactar.Name = "btnCerrarRedactar";
            this.btnCerrarRedactar.Size = new System.Drawing.Size(35, 32);
            this.btnCerrarRedactar.TabIndex = 22;
            this.btnCerrarRedactar.UseVisualStyleBackColor = true;
            this.btnCerrarRedactar.Click += new System.EventHandler(this.btnCerrarRedactar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Correo";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(5, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(5, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 1);
            this.panel3.TabIndex = 1;
            // 
            // btnRedactar
            // 
            this.btnRedactar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedactar.Location = new System.Drawing.Point(12, 9);
            this.btnRedactar.Name = "btnRedactar";
            this.btnRedactar.Size = new System.Drawing.Size(166, 48);
            this.btnRedactar.TabIndex = 22;
            this.btnRedactar.Text = "+ Redactrar";
            this.btnRedactar.UseVisualStyleBackColor = true;
            this.btnRedactar.Click += new System.EventHandler(this.btnRedactar_Click);
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.btnRedactar);
            this.Controls.Add(this.pnlRedactar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.pnlRedactar.ResumeLayout(false);
            this.pnlRedactar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Panel pnlRedactar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCerrarRedactar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRedactar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}