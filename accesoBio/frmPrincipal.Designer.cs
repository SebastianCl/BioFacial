namespace accesoBio
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbAni2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbAni1 = new System.Windows.Forms.PictureBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.liveCam = new Emgu.CV.UI.ImageBox();
            this.lblVista = new System.Windows.Forms.Label();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAni2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAni1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 10);
            this.panel2.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 44);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Bienvenid@, \r\n-----------";
            // 
            // pbAni2
            // 
            this.pbAni2.BackColor = System.Drawing.Color.Transparent;
            this.pbAni2.Image = ((System.Drawing.Image)(resources.GetObject("pbAni2.Image")));
            this.pbAni2.Location = new System.Drawing.Point(726, 128);
            this.pbAni2.Name = "pbAni2";
            this.pbAni2.Size = new System.Drawing.Size(226, 256);
            this.pbAni2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAni2.TabIndex = 49;
            this.pbAni2.TabStop = false;
            this.pbAni2.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 35);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbAni1
            // 
            this.pbAni1.BackColor = System.Drawing.Color.Transparent;
            this.pbAni1.Image = ((System.Drawing.Image)(resources.GetObject("pbAni1.Image")));
            this.pbAni1.Location = new System.Drawing.Point(12, 128);
            this.pbAni1.Name = "pbAni1";
            this.pbAni1.Size = new System.Drawing.Size(226, 256);
            this.pbAni1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAni1.TabIndex = 47;
            this.pbAni1.TabStop = false;
            this.pbAni1.Visible = false;
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Honeydew;
            this.btnActivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(343, 412);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(265, 57);
            this.btnActivar.TabIndex = 46;
            this.btnActivar.Text = "ACTIVAR RECONOCIMIENTO MULTIPLE";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // liveCam
            // 
            this.liveCam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.liveCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liveCam.InitialImage = null;
            this.liveCam.Location = new System.Drawing.Point(260, 39);
            this.liveCam.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.liveCam.Name = "liveCam";
            this.liveCam.Size = new System.Drawing.Size(435, 363);
            this.liveCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveCam.TabIndex = 45;
            this.liveCam.TabStop = false;
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVista.Location = new System.Drawing.Point(722, 427);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(192, 22);
            this.lblVista.TabIndex = 51;
            this.lblVista.Text = "Vista de -----------------";
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenuAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnMenuAdmin.Location = new System.Drawing.Point(739, 454);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(198, 23);
            this.btnMenuAdmin.TabIndex = 52;
            this.btnMenuAdmin.Text = "MENÚ DE ADMINISTRADOR";
            this.btnMenuAdmin.UseVisualStyleBackColor = true;
            this.btnMenuAdmin.Click += new System.EventHandler(this.btnMenuAdmin_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(969, 489);
            this.Controls.Add(this.btnMenuAdmin);
            this.Controls.Add(this.lblVista);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbAni2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbAni1);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.liveCam);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pbAni2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAni1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbAni2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbAni1;
        private System.Windows.Forms.Button btnActivar;
        private Emgu.CV.UI.ImageBox liveCam;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.Button btnMenuAdmin;
    }
}