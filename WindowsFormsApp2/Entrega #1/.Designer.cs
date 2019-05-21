namespace WindowsFormsApp2
{
    partial class Form2
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
            this.bttRegresar = new System.Windows.Forms.Button();
            this.txtHoracita = new System.Windows.Forms.TextBox();
            this.lblHoracita = new System.Windows.Forms.Label();
            this.dtpFechacita = new System.Windows.Forms.DateTimePicker();
            this.lblFechacita = new System.Windows.Forms.Label();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.bttguardar = new System.Windows.Forms.Button();
            this.errorMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRegresar
            // 
            this.bttRegresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttRegresar.Location = new System.Drawing.Point(460, 201);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(99, 63);
            this.bttRegresar.TabIndex = 84;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = false;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // txtHoracita
            // 
            this.txtHoracita.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoracita.Location = new System.Drawing.Point(285, 199);
            this.txtHoracita.Name = "txtHoracita";
            this.txtHoracita.Size = new System.Drawing.Size(103, 20);
            this.txtHoracita.TabIndex = 83;
            this.txtHoracita.TextChanged += new System.EventHandler(this.txtHoracita_TextChanged);
            // 
            // lblHoracita
            // 
            this.lblHoracita.AutoSize = true;
            this.lblHoracita.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoracita.Location = new System.Drawing.Point(29, 201);
            this.lblHoracita.Name = "lblHoracita";
            this.lblHoracita.Size = new System.Drawing.Size(81, 18);
            this.lblHoracita.TabIndex = 82;
            this.lblHoracita.Text = "Hora cita";
            this.lblHoracita.Click += new System.EventHandler(this.lblHoracita_Click);
            // 
            // dtpFechacita
            // 
            this.dtpFechacita.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.Location = new System.Drawing.Point(238, 145);
            this.dtpFechacita.Name = "dtpFechacita";
            this.dtpFechacita.Size = new System.Drawing.Size(200, 20);
            this.dtpFechacita.TabIndex = 81;
            this.dtpFechacita.ValueChanged += new System.EventHandler(this.dtpFechacita_ValueChanged);
            // 
            // lblFechacita
            // 
            this.lblFechacita.AutoSize = true;
            this.lblFechacita.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechacita.Location = new System.Drawing.Point(26, 151);
            this.lblFechacita.Name = "lblFechacita";
            this.lblFechacita.Size = new System.Drawing.Size(90, 18);
            this.lblFechacita.TabIndex = 80;
            this.lblFechacita.Text = "Fecha cita";
            this.lblFechacita.Click += new System.EventHandler(this.lblFechacita_Click);
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtProcedimiento.Location = new System.Drawing.Point(285, 244);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(103, 20);
            this.txtProcedimiento.TabIndex = 79;
            this.txtProcedimiento.TextChanged += new System.EventHandler(this.txtProcedimiento_TextChanged);
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.AutoSize = true;
            this.lblProcedimiento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.Location = new System.Drawing.Point(29, 254);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(125, 18);
            this.lblProcedimiento.TabIndex = 78;
            this.lblProcedimiento.Text = "Procedimiento";
            this.lblProcedimiento.Click += new System.EventHandler(this.lblProcedimiento_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTelefono.Location = new System.Drawing.Point(285, 95);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(103, 20);
            this.txtTelefono.TabIndex = 77;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(29, 94);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 18);
            this.lblTelefono.TabIndex = 76;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtIdentificacion.Location = new System.Drawing.Point(285, 55);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(103, 20);
            this.txtIdentificacion.TabIndex = 75;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(26, 57);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(212, 18);
            this.lblIdentificacion.TabIndex = 74;
            this.lblIdentificacion.Text = "Numero de Identificación";
            this.lblIdentificacion.Click += new System.EventHandler(this.lblIdentificacion_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombres.Location = new System.Drawing.Point(285, 16);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(103, 20);
            this.txtNombres.TabIndex = 86;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(26, 18);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(171, 18);
            this.lblNombres.TabIndex = 85;
            this.lblNombres.Text = "Nombres completos";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // bttguardar
            // 
            this.bttguardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttguardar.Location = new System.Drawing.Point(460, 72);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(98, 57);
            this.bttguardar.TabIndex = 87;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = false;
            this.bttguardar.Click += new System.EventHandler(this.bttguardar_Click);
            // 
            // errorMensaje
            // 
            this.errorMensaje.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.sistema_sano_del_icono_del_diente_crema_dental_del_cepillo_de_dientes_personaje_de_dibujos_animados_97101768;
            this.ClientSize = new System.Drawing.Size(680, 327);
            this.Controls.Add(this.bttguardar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.txtHoracita);
            this.Controls.Add(this.lblHoracita);
            this.Controls.Add(this.dtpFechacita);
            this.Controls.Add(this.lblFechacita);
            this.Controls.Add(this.txtProcedimiento);
            this.Controls.Add(this.lblProcedimiento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Name = "Form2";
            this.Text = "Agenda de citas";
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRegresar;
        private System.Windows.Forms.TextBox txtHoracita;
        private System.Windows.Forms.Label lblHoracita;
        private System.Windows.Forms.DateTimePicker dtpFechacita;
        private System.Windows.Forms.Label lblFechacita;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.Label lblProcedimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button bttguardar;
        private System.Windows.Forms.ErrorProvider errorMensaje;
    }
}