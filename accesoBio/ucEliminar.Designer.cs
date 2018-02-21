namespace accesoBio
{
    partial class ucEliminar
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
            this.gbCedula = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.gbCedula.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCedula
            // 
            this.gbCedula.Controls.Add(this.btnBuscar);
            this.gbCedula.Controls.Add(this.label2);
            this.gbCedula.Controls.Add(this.txtCedula);
            this.gbCedula.Location = new System.Drawing.Point(31, 22);
            this.gbCedula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbCedula.Name = "gbCedula";
            this.gbCedula.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbCedula.Size = new System.Drawing.Size(749, 98);
            this.gbCedula.TabIndex = 7;
            this.gbCedula.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(536, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(192, 45);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(148, 39);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCedula.MaxLength = 15;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(273, 27);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Controls.Add(this.label1);
            this.gbInformacion.Location = new System.Drawing.Point(31, 130);
            this.gbInformacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbInformacion.Size = new System.Drawing.Size(505, 67);
            this.gbInformacion.TabIndex = 14;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(247, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "---------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(567, 146);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 45);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(41, 228);
            this.lblMsj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(82, 22);
            this.lblMsj.TabIndex = 15;
            this.lblMsj.Text = "------------";
            this.lblMsj.Visible = false;
            // 
            // ucEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbCedula);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ucEliminar";
            this.Size = new System.Drawing.Size(924, 297);
            this.gbCedula.ResumeLayout(false);
            this.gbCedula.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.GroupBox gbInformacion;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMsj;
    }
}
