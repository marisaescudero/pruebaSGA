namespace Sga
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbllUsu = new System.Windows.Forms.Label();
            this.lbllContra = new System.Windows.Forms.Label();
            this.txtBox_Usuario_login = new System.Windows.Forms.TextBox();
            this.txtBox_Contraseña_login = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.pcCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPerdida = new System.Windows.Forms.LinkLabel();
            this.lbl_Registrarse = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            this.pbVerContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(186, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SGA";
            // 
            // lbllUsu
            // 
            this.lbllUsu.AutoSize = true;
            this.lbllUsu.BackColor = System.Drawing.Color.Transparent;
            this.lbllUsu.ForeColor = System.Drawing.Color.Blue;
            this.lbllUsu.Location = new System.Drawing.Point(70, 147);
            this.lbllUsu.Name = "lbllUsu";
            this.lbllUsu.Size = new System.Drawing.Size(313, 13);
            this.lbllUsu.TabIndex = 1;
            this.lbllUsu.Text = "___________________________________________________";
            // 
            // lbllContra
            // 
            this.lbllContra.AutoSize = true;
            this.lbllContra.BackColor = System.Drawing.Color.Transparent;
            this.lbllContra.ForeColor = System.Drawing.Color.Blue;
            this.lbllContra.Location = new System.Drawing.Point(70, 201);
            this.lbllContra.Name = "lbllContra";
            this.lbllContra.Size = new System.Drawing.Size(313, 13);
            this.lbllContra.TabIndex = 2;
            this.lbllContra.Text = "___________________________________________________";
            // 
            // txtBox_Usuario_login
            // 
            this.txtBox_Usuario_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBox_Usuario_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Usuario_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Usuario_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBox_Usuario_login.Location = new System.Drawing.Point(71, 140);
            this.txtBox_Usuario_login.MaxLength = 30;
            this.txtBox_Usuario_login.Name = "txtBox_Usuario_login";
            this.txtBox_Usuario_login.Size = new System.Drawing.Size(310, 19);
            this.txtBox_Usuario_login.TabIndex = 2;
            this.txtBox_Usuario_login.Text = "USUARIO";
            this.txtBox_Usuario_login.Enter += new System.EventHandler(this.txtUsu_Enter);
            this.txtBox_Usuario_login.Leave += new System.EventHandler(this.txtUsu_Leave);
            // 
            // txtBox_Contraseña_login
            // 
            this.txtBox_Contraseña_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBox_Contraseña_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Contraseña_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Contraseña_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBox_Contraseña_login.Location = new System.Drawing.Point(73, 192);
            this.txtBox_Contraseña_login.MaxLength = 20;
            this.txtBox_Contraseña_login.Name = "txtBox_Contraseña_login";
            this.txtBox_Contraseña_login.Size = new System.Drawing.Size(309, 19);
            this.txtBox_Contraseña_login.TabIndex = 3;
            this.txtBox_Contraseña_login.Text = "CONTRASEÑA";
            this.txtBox_Contraseña_login.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtBox_Contraseña_login.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(73, 239);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(308, 36);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // pcCerrar
            // 
            this.pcCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcCerrar.ErrorImage = null;
            this.pcCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrar.Image")));
            this.pcCerrar.InitialImage = null;
            this.pcCerrar.Location = new System.Drawing.Point(418, -1);
            this.pcCerrar.Name = "pcCerrar";
            this.pcCerrar.Size = new System.Drawing.Size(27, 26);
            this.pcCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCerrar.TabIndex = 6;
            this.pcCerrar.TabStop = false;
            this.pcCerrar.Click += new System.EventHandler(this.pcCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(390, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPerdida
            // 
            this.lblPerdida.AutoSize = true;
            this.lblPerdida.BackColor = System.Drawing.Color.Transparent;
            this.lblPerdida.Location = new System.Drawing.Point(213, 289);
            this.lblPerdida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerdida.Name = "lblPerdida";
            this.lblPerdida.Size = new System.Drawing.Size(149, 13);
            this.lblPerdida.TabIndex = 1;
            this.lblPerdida.TabStop = true;
            this.lblPerdida.Text = "¿Has olvidado tu contraseña?";
            // 
            // lbl_Registrarse
            // 
            this.lbl_Registrarse.AutoSize = true;
            this.lbl_Registrarse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Registrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Registrarse.Location = new System.Drawing.Point(87, 289);
            this.lbl_Registrarse.Name = "lbl_Registrarse";
            this.lbl_Registrarse.Size = new System.Drawing.Size(102, 13);
            this.lbl_Registrarse.TabIndex = 8;
            this.lbl_Registrarse.Text = "Registrar Profesores";
            this.lbl_Registrarse.Click += new System.EventHandler(this.lbl_Registrarse_Click);
            this.lbl_Registrarse.MouseEnter += new System.EventHandler(this.lbl_Registrarse_MouseEnter);
            this.lbl_Registrarse.MouseLeave += new System.EventHandler(this.lbl_Registrarse_MouseLeave);
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.BackColor = System.Drawing.Color.Transparent;
            this.lbl_o.Location = new System.Drawing.Point(195, 289);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(13, 13);
            this.lbl_o.TabIndex = 9;
            this.lbl_o.Text = "o";
            // 
            // pbVerContraseña
            // 
            this.pbVerContraseña.BackColor = System.Drawing.Color.Transparent;
            this.pbVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVerContraseña.Image = global::Sga.Properties.Resources.ojo1;
            this.pbVerContraseña.Location = new System.Drawing.Point(355, 185);
            this.pbVerContraseña.Name = "pbVerContraseña";
            this.pbVerContraseña.Size = new System.Drawing.Size(26, 26);
            this.pbVerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVerContraseña.TabIndex = 10;
            this.pbVerContraseña.TabStop = false;
            this.pbVerContraseña.Click += new System.EventHandler(this.pbVerContraseña_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.pbVerContraseña);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.lbl_Registrarse);
            this.Controls.Add(this.lblPerdida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcCerrar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtBox_Contraseña_login);
            this.Controls.Add(this.txtBox_Usuario_login);
            this.Controls.Add(this.lbllContra);
            this.Controls.Add(this.lbllUsu);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbllUsu;
        private System.Windows.Forms.Label lbllContra;
        private System.Windows.Forms.TextBox txtBox_Usuario_login;
        private System.Windows.Forms.TextBox txtBox_Contraseña_login;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.PictureBox pcCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblPerdida;
        private System.Windows.Forms.Label lbl_Registrarse;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.PictureBox pbVerContraseña;
    }
}

