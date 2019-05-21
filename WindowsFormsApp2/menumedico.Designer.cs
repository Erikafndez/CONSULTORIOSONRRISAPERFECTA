namespace WindowsFormsApp2
{
    partial class form5
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
            this.bttRegresar = new System.Windows.Forms.Button();
            this.bttReportes = new System.Windows.Forms.Button();
            this.bttTratamiento = new System.Windows.Forms.Button();
            this.bttAgendadecita = new System.Windows.Forms.Button();
            this.bttRequisitodepaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttRegresar
            // 
            this.bttRegresar.BackColor = System.Drawing.Color.Silver;
            this.bttRegresar.Location = new System.Drawing.Point(161, 294);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(173, 84);
            this.bttRegresar.TabIndex = 4;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = false;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // bttReportes
            // 
            this.bttReportes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttReportes.Location = new System.Drawing.Point(294, 142);
            this.bttReportes.Name = "bttReportes";
            this.bttReportes.Size = new System.Drawing.Size(173, 94);
            this.bttReportes.TabIndex = 3;
            this.bttReportes.Text = "Reportes";
            this.bttReportes.UseVisualStyleBackColor = false;
            this.bttReportes.Click += new System.EventHandler(this.bttReportes_Click);
            // 
            // bttTratamiento
            // 
            this.bttTratamiento.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttTratamiento.Location = new System.Drawing.Point(55, 147);
            this.bttTratamiento.Name = "bttTratamiento";
            this.bttTratamiento.Size = new System.Drawing.Size(165, 85);
            this.bttTratamiento.TabIndex = 2;
            this.bttTratamiento.Text = "Tratamiento a realizar";
            this.bttTratamiento.UseVisualStyleBackColor = false;
            this.bttTratamiento.Click += new System.EventHandler(this.bttTratamiento_Click);
            // 
            // bttAgendadecita
            // 
            this.bttAgendadecita.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAgendadecita.Location = new System.Drawing.Point(55, 22);
            this.bttAgendadecita.Name = "bttAgendadecita";
            this.bttAgendadecita.Size = new System.Drawing.Size(165, 89);
            this.bttAgendadecita.TabIndex = 0;
            this.bttAgendadecita.Text = "Agenda de cita ";
            this.bttAgendadecita.UseVisualStyleBackColor = false;
            this.bttAgendadecita.Click += new System.EventHandler(this.bttAgendadecita_Click);
            // 
            // bttRequisitodepaciente
            // 
            this.bttRequisitodepaciente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttRequisitodepaciente.Location = new System.Drawing.Point(294, 24);
            this.bttRequisitodepaciente.Name = "bttRequisitodepaciente";
            this.bttRequisitodepaciente.Size = new System.Drawing.Size(173, 84);
            this.bttRequisitodepaciente.TabIndex = 1;
            this.bttRequisitodepaciente.Text = "Informacion del paciente";
            this.bttRequisitodepaciente.UseVisualStyleBackColor = false;
            this.bttRequisitodepaciente.Click += new System.EventHandler(this.bttRequisitodepaciente_Click);
            // 
            // form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.gettyimages_939806920_170667a;
            this.ClientSize = new System.Drawing.Size(518, 401);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.bttReportes);
            this.Controls.Add(this.bttTratamiento);
            this.Controls.Add(this.bttAgendadecita);
            this.Controls.Add(this.bttRequisitodepaciente);
            this.Name = "form5";
            this.Text = "Menu Medico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttRegresar;
        private System.Windows.Forms.Button bttReportes;
        private System.Windows.Forms.Button bttTratamiento;
        private System.Windows.Forms.Button bttAgendadecita;
        private System.Windows.Forms.Button bttRequisitodepaciente;
    }
}