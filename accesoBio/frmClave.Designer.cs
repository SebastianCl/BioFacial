namespace accesoBio
{
    partial class frmClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClave));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.lblMsj = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            this.gbPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta de seguridad:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(262, 27);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(226, 22);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(266, 69);
            this.txtRespuesta.MaxLength = 50;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(263, 31);
            this.txtRespuesta.TabIndex = 3;
            this.txtRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(561, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbPregunta
            // 
            this.gbPregunta.Controls.Add(this.label1);
            this.gbPregunta.Controls.Add(this.btnAceptar);
            this.gbPregunta.Controls.Add(this.lblPregunta);
            this.gbPregunta.Controls.Add(this.txtRespuesta);
            this.gbPregunta.Controls.Add(this.label3);
            this.gbPregunta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPregunta.Location = new System.Drawing.Point(12, 42);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(723, 134);
            this.gbPregunta.TabIndex = 5;
            this.gbPregunta.TabStop = false;
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.Location = new System.Drawing.Point(31, 227);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(141, 30);
            this.lblMsj.TabIndex = 6;
            this.lblMsj.Text = "----------------";
            this.lblMsj.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 10);
            this.panel2.TabIndex = 20;
            // 
            // pbVolver
            // 
            this.pbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolver.Image = ((System.Drawing.Image)(resources.GetObject("pbVolver.Image")));
            this.pbVolver.Location = new System.Drawing.Point(780, 69);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(96, 96);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVolver.TabIndex = 21;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pbVolver_Click);
            // 
            // frmClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 386);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.gbPregunta);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClave";
            this.gbPregunta.ResumeLayout(false);
            this.gbPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbVolver;
    }
}