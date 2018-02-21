namespace accesoBio
{
    partial class ucRegistrar
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
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.gbSeguridad = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.gbTipo.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbSeguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rdbUsuario);
            this.gbTipo.Controls.Add(this.rdbAdmin);
            this.gbTipo.Location = new System.Drawing.Point(21, 12);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(276, 52);
            this.gbTipo.TabIndex = 0;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de registro";
            // 
            // rdbUsuario
            // 
            this.rdbUsuario.AutoSize = true;
            this.rdbUsuario.Location = new System.Drawing.Point(33, 20);
            this.rdbUsuario.Name = "rdbUsuario";
            this.rdbUsuario.Size = new System.Drawing.Size(65, 20);
            this.rdbUsuario.TabIndex = 1;
            this.rdbUsuario.TabStop = true;
            this.rdbUsuario.Text = "Usuario";
            this.rdbUsuario.UseVisualStyleBackColor = true;
            this.rdbUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbUsuario_MouseClick);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(139, 20);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(99, 20);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            this.rdbAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbAdmin_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 28);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 21);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtCedula);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(27, 90);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(270, 96);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(81, 55);
            this.txtCedula.MaxLength = 15;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 21);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // gbSeguridad
            // 
            this.gbSeguridad.Controls.Add(this.label5);
            this.gbSeguridad.Controls.Add(this.txtRespuesta);
            this.gbSeguridad.Controls.Add(this.label6);
            this.gbSeguridad.Controls.Add(this.txtPregunta);
            this.gbSeguridad.Controls.Add(this.label3);
            this.gbSeguridad.Controls.Add(this.txtClave2);
            this.gbSeguridad.Controls.Add(this.label4);
            this.gbSeguridad.Controls.Add(this.txtClave1);
            this.gbSeguridad.Location = new System.Drawing.Point(354, 12);
            this.gbSeguridad.Name = "gbSeguridad";
            this.gbSeguridad.Size = new System.Drawing.Size(321, 149);
            this.gbSeguridad.TabIndex = 5;
            this.gbSeguridad.TabStop = false;
            this.gbSeguridad.Text = "Seguridad";
            this.gbSeguridad.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(150, 109);
            this.txtRespuesta.MaxLength = 50;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(151, 21);
            this.txtRespuesta.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pregunta:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(150, 82);
            this.txtPregunta.MaxLength = 50;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(151, 21);
            this.txtPregunta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // txtClave2
            // 
            this.txtClave2.Location = new System.Drawing.Point(150, 55);
            this.txtClave2.MaxLength = 5;
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(151, 21);
            this.txtClave2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña: ";
            // 
            // txtClave1
            // 
            this.txtClave1.Location = new System.Drawing.Point(150, 28);
            this.txtClave1.MaxLength = 5;
            this.txtClave1.Name = "txtClave1";
            this.txtClave1.PasswordChar = '*';
            this.txtClave1.Size = new System.Drawing.Size(151, 21);
            this.txtClave1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(354, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 46);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(550, 182);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 46);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(24, 197);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(60, 16);
            this.lblMsj.TabIndex = 8;
            this.lblMsj.Text = "-------------";
            this.lblMsj.Visible = false;
            // 
            // ucRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbSeguridad);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbTipo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucRegistrar";
            this.Size = new System.Drawing.Size(792, 241);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbSeguridad.ResumeLayout(false);
            this.gbSeguridad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rdbUsuario;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.GroupBox gbSeguridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.GroupBox gbDatos;
        protected System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMsj;
    }
}
