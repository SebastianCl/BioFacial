namespace accesoBio
{
    partial class ucBuscar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBuscar));
            this.gbNomCed = new System.Windows.Forms.GroupBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsj = new System.Windows.Forms.Label();
            this.gbNomCed.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNomCed
            // 
            this.gbNomCed.Controls.Add(this.btnBusqueda);
            this.gbNomCed.Controls.Add(this.txtCedula);
            this.gbNomCed.Controls.Add(this.label2);
            this.gbNomCed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNomCed.Location = new System.Drawing.Point(6, 37);
            this.gbNomCed.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbNomCed.Name = "gbNomCed";
            this.gbNomCed.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbNomCed.Size = new System.Drawing.Size(642, 118);
            this.gbNomCed.TabIndex = 10;
            this.gbNomCed.TabStop = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(425, 27);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(163, 63);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(161, 42);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCedula.MaxLength = 15;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(180, 31);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula";
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.pbCheck);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Location = new System.Drawing.Point(6, 176);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(642, 58);
            this.gbInformacion.TabIndex = 11;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Visible = false;
            // 
            // pbCheck
            // 
            this.pbCheck.Image = ((System.Drawing.Image)(resources.GetObject("pbCheck.Image")));
            this.pbCheck.Location = new System.Drawing.Point(425, 18);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(37, 34);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCheck.TabIndex = 12;
            this.pbCheck.TabStop = false;
            this.pbCheck.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(157, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "---------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(12, 160);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(100, 22);
            this.lblMsj.TabIndex = 3;
            this.lblMsj.Text = "---------------";
            this.lblMsj.Visible = false;
            // 
            // ucBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbNomCed);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ucBuscar";
            this.Size = new System.Drawing.Size(792, 241);
            this.gbNomCed.ResumeLayout(false);
            this.gbNomCed.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNomCed;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsj;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbCheck;
    }
}
