namespace accesoBio
{
    partial class frmLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.liveCam = new Emgu.CV.UI.ImageBox();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbAnim = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.gbClave = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnim)).BeginInit();
            this.gbClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // liveCam
            // 
            this.liveCam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.liveCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liveCam.InitialImage = null;
            this.liveCam.Location = new System.Drawing.Point(558, 171);
            this.liveCam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liveCam.Name = "liveCam";
            this.liveCam.Size = new System.Drawing.Size(320, 240);
            this.liveCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveCam.TabIndex = 14;
            this.liveCam.TabStop = false;
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Enabled = false;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(558, 35);
            this.pbConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(133, 128);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConfirmar.TabIndex = 15;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Visible = false;
            this.pbConfirmar.Click += new System.EventHandler(this.pbConfirmar_Click);
            // 
            // pbCamara
            // 
            this.pbCamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCamara.Image = ((System.Drawing.Image)(resources.GetObject("pbCamara.Image")));
            this.pbCamara.Location = new System.Drawing.Point(741, 35);
            this.pbCamara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(128, 128);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCamara.TabIndex = 18;
            this.pbCamara.TabStop = false;
            this.pbCamara.Click += new System.EventHandler(this.pbCamara_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 10);
            this.panel2.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 35);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbAnim
            // 
            this.pbAnim.Image = ((System.Drawing.Image)(resources.GetObject("pbAnim.Image")));
            this.pbAnim.Location = new System.Drawing.Point(66, 12);
            this.pbAnim.Name = "pbAnim";
            this.pbAnim.Size = new System.Drawing.Size(207, 127);
            this.pbAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnim.TabIndex = 20;
            this.pbAnim.TabStop = false;
            this.pbAnim.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(74, 171);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(320, 25);
            this.lblMensaje.TabIndex = 17;
            this.lblMensaje.Text = "Bienvenido ---------------------";
            this.lblMensaje.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(167, 25);
            this.txtContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(206, 44);
            this.txtContra.TabIndex = 17;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(8, 128);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(153, 16);
            this.lblClave.TabIndex = 17;
            this.lblClave.TabStop = true;
            this.lblClave.Text = "¿Olvidaste la contraseña?";
            this.lblClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClave_LinkClicked);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(167, 86);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(206, 70);
            this.btnAcceder.TabIndex = 17;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // gbClave
            // 
            this.gbClave.Controls.Add(this.btnAcceder);
            this.gbClave.Controls.Add(this.lblClave);
            this.gbClave.Controls.Add(this.txtContra);
            this.gbClave.Controls.Add(this.label1);
            this.gbClave.Location = new System.Drawing.Point(66, 247);
            this.gbClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbClave.Name = "gbClave";
            this.gbClave.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbClave.Size = new System.Drawing.Size(379, 164);
            this.gbClave.TabIndex = 16;
            this.gbClave.TabStop = false;
            this.gbClave.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbAnim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbCamara);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbClave);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.liveCam);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototipo de control de acceso biometrico con reconocimiento facial";
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnim)).EndInit();
            this.gbClave.ResumeLayout(false);
            this.gbClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox liveCam;
        private System.Windows.Forms.PictureBox pbConfirmar;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbAnim;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.LinkLabel lblClave;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.GroupBox gbClave;
    }
}

