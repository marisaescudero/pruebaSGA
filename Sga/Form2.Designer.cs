namespace Sga
{
    partial class GestionEstudiantes
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
            this.txtBox_G_cédulaAlumno = new System.Windows.Forms.TextBox();
            this.txtBox_G_nombresAlumno = new System.Windows.Forms.TextBox();
            this.lbnConfirmar = new System.Windows.Forms.Button();
            this.lbnEliminar = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistroEstudiante = new System.Windows.Forms.Label();
            this.dvg_Gestion_estudiante = new System.Windows.Forms.DataGridView();
            this.txtBox_G_nombres_madre = new System.Windows.Forms.TextBox();
            this.txtBox_G_telefono = new System.Windows.Forms.TextBox();
            this.txtBox_G_Gmail = new System.Windows.Forms.TextBox();
            this.txtBox_G_nombresPadre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Gestion_estudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_G_cédulaAlumno
            // 
            this.txtBox_G_cédulaAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_cédulaAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_cédulaAlumno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_cédulaAlumno.Location = new System.Drawing.Point(333, 101);
            this.txtBox_G_cédulaAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_G_cédulaAlumno.MaxLength = 10;
            this.txtBox_G_cédulaAlumno.Name = "txtBox_G_cédulaAlumno";
            this.txtBox_G_cédulaAlumno.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_cédulaAlumno.TabIndex = 19;
            // 
            // txtBox_G_nombresAlumno
            // 
            this.txtBox_G_nombresAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_nombresAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_nombresAlumno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_nombresAlumno.Location = new System.Drawing.Point(333, 61);
            this.txtBox_G_nombresAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_G_nombresAlumno.MaxLength = 50;
            this.txtBox_G_nombresAlumno.Name = "txtBox_G_nombresAlumno";
            this.txtBox_G_nombresAlumno.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_nombresAlumno.TabIndex = 18;
            this.txtBox_G_nombresAlumno.TextChanged += new System.EventHandler(this.txtBox_G_nombresAlumno_TextChanged);
            // 
            // lbnConfirmar
            // 
            this.lbnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.lbnConfirmar.FlatAppearance.BorderSize = 0;
            this.lbnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbnConfirmar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnConfirmar.Location = new System.Drawing.Point(585, 98);
            this.lbnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.lbnConfirmar.Name = "lbnConfirmar";
            this.lbnConfirmar.Size = new System.Drawing.Size(102, 33);
            this.lbnConfirmar.TabIndex = 25;
            this.lbnConfirmar.Text = "Guardar";
            this.lbnConfirmar.UseVisualStyleBackColor = false;
            this.lbnConfirmar.Click += new System.EventHandler(this.lbnConfirmar_Click);
            this.lbnConfirmar.MouseEnter += new System.EventHandler(this.lbnConfirmar_MouseEnter);
            this.lbnConfirmar.MouseLeave += new System.EventHandler(this.lbnConfirmar_MouseLeave);
            // 
            // lbnEliminar
            // 
            this.lbnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.lbnEliminar.FlatAppearance.BorderSize = 0;
            this.lbnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnEliminar.Location = new System.Drawing.Point(585, 213);
            this.lbnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.lbnEliminar.Name = "lbnEliminar";
            this.lbnEliminar.Size = new System.Drawing.Size(102, 33);
            this.lbnEliminar.TabIndex = 28;
            this.lbnEliminar.Text = "Eliminar";
            this.lbnEliminar.UseVisualStyleBackColor = false;
            this.lbnEliminar.Click += new System.EventHandler(this.lbnEliminar_Click);
            this.lbnEliminar.MouseEnter += new System.EventHandler(this.lbnEliminar_MouseEnter);
            this.lbnEliminar.MouseLeave += new System.EventHandler(this.lbnEliminar_MouseLeave);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(21, 98);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(185, 24);
            this.lblCedula.TabIndex = 14;
            this.lblCedula.Text = "Cédula del Alumno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombres Completos del Alumno:";
            // 
            // lblRegistroEstudiante
            // 
            this.lblRegistroEstudiante.AutoSize = true;
            this.lblRegistroEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroEstudiante.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEstudiante.Location = new System.Drawing.Point(223, 9);
            this.lblRegistroEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroEstudiante.Name = "lblRegistroEstudiante";
            this.lblRegistroEstudiante.Size = new System.Drawing.Size(268, 31);
            this.lblRegistroEstudiante.TabIndex = 11;
            this.lblRegistroEstudiante.Text = "Gestionar Estudiantes";
            // 
            // dvg_Gestion_estudiante
            // 
            this.dvg_Gestion_estudiante.AllowUserToAddRows = false;
            this.dvg_Gestion_estudiante.AllowUserToDeleteRows = false;
            this.dvg_Gestion_estudiante.AllowUserToResizeColumns = false;
            this.dvg_Gestion_estudiante.AllowUserToResizeRows = false;
            this.dvg_Gestion_estudiante.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dvg_Gestion_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Gestion_estudiante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvg_Gestion_estudiante.Location = new System.Drawing.Point(0, 332);
            this.dvg_Gestion_estudiante.Name = "dvg_Gestion_estudiante";
            this.dvg_Gestion_estudiante.ReadOnly = true;
            this.dvg_Gestion_estudiante.Size = new System.Drawing.Size(718, 184);
            this.dvg_Gestion_estudiante.TabIndex = 24;
            this.dvg_Gestion_estudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_Gestion_estudiante_CellClick);
            // 
            // txtBox_G_nombres_madre
            // 
            this.txtBox_G_nombres_madre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBox_G_nombres_madre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_nombres_madre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_nombres_madre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_nombres_madre.Location = new System.Drawing.Point(333, 175);
            this.txtBox_G_nombres_madre.MaxLength = 50;
            this.txtBox_G_nombres_madre.Name = "txtBox_G_nombres_madre";
            this.txtBox_G_nombres_madre.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_nombres_madre.TabIndex = 21;
            // 
            // txtBox_G_telefono
            // 
            this.txtBox_G_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBox_G_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_telefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_telefono.Location = new System.Drawing.Point(333, 216);
            this.txtBox_G_telefono.MaxLength = 10;
            this.txtBox_G_telefono.Name = "txtBox_G_telefono";
            this.txtBox_G_telefono.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_telefono.TabIndex = 22;
            // 
            // txtBox_G_Gmail
            // 
            this.txtBox_G_Gmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBox_G_Gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_Gmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_Gmail.Location = new System.Drawing.Point(333, 251);
            this.txtBox_G_Gmail.MaxLength = 20;
            this.txtBox_G_Gmail.Name = "txtBox_G_Gmail";
            this.txtBox_G_Gmail.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_Gmail.TabIndex = 23;
            // 
            // txtBox_G_nombresPadre
            // 
            this.txtBox_G_nombresPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBox_G_nombresPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.txtBox_G_nombresPadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_G_nombresPadre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_G_nombresPadre.Location = new System.Drawing.Point(333, 138);
            this.txtBox_G_nombresPadre.MaxLength = 50;
            this.txtBox_G_nombresPadre.Name = "txtBox_G_nombresPadre";
            this.txtBox_G_nombresPadre.Size = new System.Drawing.Size(187, 22);
            this.txtBox_G_nombresPadre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 118;
            this.label2.Text = "Nombres Completos de la Madre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 24);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nombres Completos del Padre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 120;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 119;
            this.label6.Text = "Correo electrónico:";
            // 
            // GestionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.fondo_formularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_G_nombres_madre);
            this.Controls.Add(this.txtBox_G_telefono);
            this.Controls.Add(this.txtBox_G_Gmail);
            this.Controls.Add(this.txtBox_G_nombresPadre);
            this.Controls.Add(this.dvg_Gestion_estudiante);
            this.Controls.Add(this.txtBox_G_cédulaAlumno);
            this.Controls.Add(this.txtBox_G_nombresAlumno);
            this.Controls.Add(this.lbnConfirmar);
            this.Controls.Add(this.lbnEliminar);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistroEstudiante);
            this.Name = "GestionEstudiantes";
            this.Text = "Gestion de alumnos";
            this.Load += new System.EventHandler(this.GestionEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Gestion_estudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_G_cédulaAlumno;
        private System.Windows.Forms.TextBox txtBox_G_nombresAlumno;
        private System.Windows.Forms.Button lbnConfirmar;
        private System.Windows.Forms.Button lbnEliminar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistroEstudiante;
        private System.Windows.Forms.DataGridView dvg_Gestion_estudiante;
        private System.Windows.Forms.TextBox txtBox_G_nombres_madre;
        private System.Windows.Forms.TextBox txtBox_G_telefono;
        private System.Windows.Forms.TextBox txtBox_G_Gmail;
        private System.Windows.Forms.TextBox txtBox_G_nombresPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}