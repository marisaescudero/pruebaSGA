namespace Sga
{
    partial class Asistencia00
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
            this.lbnRegistro = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnRegistro
            // 
            this.lbnRegistro.Location = new System.Drawing.Point(121, 146);
            this.lbnRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbnRegistro.Name = "lbnRegistro";
            this.lbnRegistro.Size = new System.Drawing.Size(128, 91);
            this.lbnRegistro.TabIndex = 0;
            this.lbnRegistro.Text = "Registro de estudiantes";
            this.lbnRegistro.UseVisualStyleBackColor = true;
            this.lbnRegistro.Click += new System.EventHandler(this.lbnRegistro_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(345, 146);
            this.btnLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(128, 91);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lbnRegistro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lbnRegistro;
        private System.Windows.Forms.Button btnLista;
    }
}