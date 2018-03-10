namespace accesoBio
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.liveCam = new Emgu.CV.UI.ImageBox();
            this.imbFoto = new Emgu.CV.UI.ImageBox();
            this.pbLiveCam = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbOFF = new System.Windows.Forms.PictureBox();
            this.ucEliminar1 = new accesoBio.ucEliminar();
            this.ucModificar1 = new accesoBio.ucModificar();
            this.ucRegistrar1 = new accesoBio.ucRegistrar();
            this.ucBuscar1 = new accesoBio.ucBuscar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOFF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 654);
            this.panel1.TabIndex = 1;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Image")));
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(10, 532);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(230, 66);
            this.btnPrincipal.TabIndex = 40;
            this.btnPrincipal.Text = "       Principal";
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 35);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(10, 279);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 66);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "       Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(14, 206);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 66);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "       Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 672);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 42);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(14, 139);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(230, 66);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "       Registro";
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(14, 73);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(230, 66);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "       Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // liveCam
            // 
            this.liveCam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.liveCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liveCam.InitialImage = null;
            this.liveCam.Location = new System.Drawing.Point(307, 73);
            this.liveCam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.liveCam.Name = "liveCam";
            this.liveCam.Size = new System.Drawing.Size(373, 295);
            this.liveCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveCam.TabIndex = 15;
            this.liveCam.TabStop = false;
            // 
            // imbFoto
            // 
            this.imbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.imbFoto.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.imbFoto.Location = new System.Drawing.Point(959, 113);
            this.imbFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imbFoto.Name = "imbFoto";
            this.imbFoto.Size = new System.Drawing.Size(150, 150);
            this.imbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbFoto.TabIndex = 30;
            this.imbFoto.TabStop = false;
            // 
            // pbLiveCam
            // 
            this.pbLiveCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLiveCam.Image = ((System.Drawing.Image)(resources.GetObject("pbLiveCam.Image")));
            this.pbLiveCam.Location = new System.Drawing.Point(752, 151);
            this.pbLiveCam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLiveCam.Name = "pbLiveCam";
            this.pbLiveCam.Size = new System.Drawing.Size(152, 105);
            this.pbLiveCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLiveCam.TabIndex = 32;
            this.pbLiveCam.TabStop = false;
            this.pbLiveCam.Click += new System.EventHandler(this.pbLiveCam_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(992, 271);
            this.btnVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(87, 28);
            this.btnVer.TabIndex = 34;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(795, 310);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 35;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Visible = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 10);
            this.panel2.TabIndex = 37;
            // 
            // pbOFF
            // 
            this.pbOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOFF.Image = ((System.Drawing.Image)(resources.GetObject("pbOFF.Image")));
            this.pbOFF.Location = new System.Drawing.Point(317, 33);
            this.pbOFF.Name = "pbOFF";
            this.pbOFF.Size = new System.Drawing.Size(32, 32);
            this.pbOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOFF.TabIndex = 39;
            this.pbOFF.TabStop = false;
            this.pbOFF.Click += new System.EventHandler(this.pbOFF_Click);
            // 
            // ucEliminar1
            // 
            this.ucEliminar1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEliminar1.Location = new System.Drawing.Point(244, 352);
            this.ucEliminar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucEliminar1.Name = "ucEliminar1";
            this.ucEliminar1.Size = new System.Drawing.Size(924, 297);
            this.ucEliminar1.TabIndex = 38;

            // 
            // ucModificar1
            // 
            this.ucModificar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucModificar1.Location = new System.Drawing.Point(246, 340);
            this.ucModificar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucModificar1.Name = "ucModificar1";
            this.ucModificar1.Size = new System.Drawing.Size(924, 297);
            this.ucModificar1.TabIndex = 36;
            // 
            // ucRegistrar1
            // 
            this.ucRegistrar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucRegistrar1.Location = new System.Drawing.Point(251, 352);
            this.ucRegistrar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucRegistrar1.Name = "ucRegistrar1";
            this.ucRegistrar1.Size = new System.Drawing.Size(924, 297);
            this.ucRegistrar1.TabIndex = 33;
            // 
            // ucBuscar1
            // 
            this.ucBuscar1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBuscar1.Location = new System.Drawing.Point(251, 340);
            this.ucBuscar1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucBuscar1.Name = "ucBuscar1";
            this.ucBuscar1.Size = new System.Drawing.Size(924, 297);
            this.ucBuscar1.TabIndex = 16;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 654);
            this.Controls.Add(this.pbOFF);
            this.Controls.Add(this.ucEliminar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucModificar1);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.ucRegistrar1);
            this.Controls.Add(this.pbLiveCam);
            this.Controls.Add(this.imbFoto);
            this.Controls.Add(this.ucBuscar1);
            this.Controls.Add(this.liveCam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liveCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnBuscar;
        private Emgu.CV.UI.ImageBox liveCam;
        private ucBuscar ucBuscar1;
        public Emgu.CV.UI.ImageBox imbFoto;
        private System.Windows.Forms.PictureBox pbLiveCam;
        private ucRegistrar ucRegistrar1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCapturar;
        private ucModificar ucModificar1;
        private System.Windows.Forms.Panel panel2;
        private ucEliminar ucEliminar1;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.PictureBox pbOFF;
        private System.Windows.Forms.Button btnPrincipal;
    }
}