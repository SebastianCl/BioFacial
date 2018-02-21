namespace accesoBio
{
    partial class ucModificar
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
            this.gbSeguridad = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblClave2 = new System.Windows.Forms.Label();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave1 = new System.Windows.Forms.TextBox();
            this.gbCedula = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.lblMsj = new System.Windows.Forms.Label();
            this.gbSeguridad.SuspendLayout();
            this.gbCedula.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSeguridad
            // 
            this.gbSeguridad.Controls.Add(this.label5);
            this.gbSeguridad.Controls.Add(this.txtRespuesta);
            this.gbSeguridad.Controls.Add(this.label6);
            this.gbSeguridad.Controls.Add(this.txtPregunta);
            this.gbSeguridad.Controls.Add(this.lblClave2);
            this.gbSeguridad.Controls.Add(this.txtClave2);
            this.gbSeguridad.Controls.Add(this.label4);
            this.gbSeguridad.Controls.Add(this.txtClave1);
            this.gbSeguridad.Enabled = false;
            this.gbSeguridad.Location = new System.Drawing.Point(491, 20);
            this.gbSeguridad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSeguridad.Name = "gbSeguridad";
            this.gbSeguridad.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSeguridad.Size = new System.Drawing.Size(374, 183);
            this.gbSeguridad.TabIndex = 7;
            this.gbSeguridad.TabStop = false;
            this.gbSeguridad.Text = "Seguridad";
            this.gbSeguridad.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(175, 134);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRespuesta.MaxLength = 50;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(175, 21);
            this.txtRespuesta.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pregunta:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(175, 101);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPregunta.MaxLength = 50;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(175, 21);
            this.txtPregunta.TabIndex = 6;
            // 
            // lblClave2
            // 
            this.lblClave2.AutoSize = true;
            this.lblClave2.Location = new System.Drawing.Point(7, 68);
            this.lblClave2.Name = "lblClave2";
            this.lblClave2.Size = new System.Drawing.Size(128, 16);
            this.lblClave2.TabIndex = 3;
            this.lblClave2.Text = "Confirmar contraseña:";
            // 
            // txtClave2
            // 
            this.txtClave2.Location = new System.Drawing.Point(175, 68);
            this.txtClave2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave2.MaxLength = 5;
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(175, 21);
            this.txtClave2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña: ";
            // 
            // txtClave1
            // 
            this.txtClave1.Location = new System.Drawing.Point(175, 34);
            this.txtClave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave1.MaxLength = 5;
            this.txtClave1.Name = "txtClave1";
            this.txtClave1.PasswordChar = '*';
            this.txtClave1.Size = new System.Drawing.Size(175, 21);
            this.txtClave1.TabIndex = 2;
            // 
            // gbCedula
            // 
            this.gbCedula.Controls.Add(this.btnBuscar);
            this.gbCedula.Controls.Add(this.label2);
            this.gbCedula.Controls.Add(this.txtCedula);
            this.gbCedula.Location = new System.Drawing.Point(21, 21);
            this.gbCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Name = "gbCedula";
            this.gbCedula.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Size = new System.Drawing.Size(463, 71);
            this.gbCedula.TabIndex = 6;
            this.gbCedula.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(323, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 33);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(108, 23);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.MaxLength = 15;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(175, 27);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.txtCc);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(21, 181);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(283, 96);
            this.gbDatos.TabIndex = 8;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            this.gbDatos.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cedula";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(81, 55);
            this.txtCc.MaxLength = 15;
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(195, 21);
            this.txtCc.TabIndex = 4;
            this.txtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCc_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 28);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 21);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(344, 132);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(491, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 46);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Enabled = false;
            this.btnDeshacer.Location = new System.Drawing.Point(685, 210);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(125, 46);
            this.btnDeshacer.TabIndex = 10;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Visible = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rdbUsuario);
            this.gbTipo.Controls.Add(this.rdbAdmin);
            this.gbTipo.Enabled = false;
            this.gbTipo.Location = new System.Drawing.Point(23, 123);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(235, 52);
            this.gbTipo.TabIndex = 11;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de registro";
            this.gbTipo.Visible = false;
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
            this.rdbAdmin.Location = new System.Drawing.Point(108, 20);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(99, 20);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            this.rdbAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbAdmin_MouseClick);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(20, 95);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(56, 16);
            this.lblMsj.TabIndex = 12;
            this.lblMsj.Text = "------------";
            this.lblMsj.Visible = false;
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbSeguridad);
            this.Controls.Add(this.gbCedula);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(924, 297);
            this.gbSeguridad.ResumeLayout(false);
            this.gbSeguridad.PerformLayout();
            this.gbCedula.ResumeLayout(false);
            this.gbCedula.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSeguridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblClave2;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave1;
        public System.Windows.Forms.GroupBox gbCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label label11;
        protected System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rdbUsuario;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Label lblMsj;
    }
}
