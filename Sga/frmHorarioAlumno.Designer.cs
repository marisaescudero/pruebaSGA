namespace Sga
{
    partial class frmHorarioAlumno
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
            this.lblHorarioAlumno = new System.Windows.Forms.Label();
            this.dgvHorarioAlumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorarioAlumno
            // 
            this.lblHorarioAlumno.AutoSize = true;
            this.lblHorarioAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioAlumno.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioAlumno.Location = new System.Drawing.Point(235, 19);
            this.lblHorarioAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioAlumno.Name = "lblHorarioAlumno";
            this.lblHorarioAlumno.Size = new System.Drawing.Size(221, 31);
            this.lblHorarioAlumno.TabIndex = 12;
            this.lblHorarioAlumno.Text = "Horario de Clases";
            // 
            // dgvHorarioAlumno
            // 
            this.dgvHorarioAlumno.AllowUserToAddRows = false;
            this.dgvHorarioAlumno.AllowUserToDeleteRows = false;
            this.dgvHorarioAlumno.AllowUserToResizeColumns = false;
            this.dgvHorarioAlumno.AllowUserToResizeRows = false;
            this.dgvHorarioAlumno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHorarioAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarioAlumno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHorarioAlumno.Location = new System.Drawing.Point(0, 70);
            this.dgvHorarioAlumno.Name = "dgvHorarioAlumno";
            this.dgvHorarioAlumno.ReadOnly = true;
            this.dgvHorarioAlumno.Size = new System.Drawing.Size(718, 446);
            this.dgvHorarioAlumno.TabIndex = 25;
            // 
            // frmHorarioAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sga.Properties.Resources.fondo_formularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.dgvHorarioAlumno);
            this.Controls.Add(this.lblHorarioAlumno);
            this.Name = "frmHorarioAlumno";
            this.Text = "frmHorarioAlumno";
            this.Load += new System.EventHandler(this.frmHorarioAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorarioAlumno;
        private System.Windows.Forms.DataGridView dgvHorarioAlumno;
    }
}