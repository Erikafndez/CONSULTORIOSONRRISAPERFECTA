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
            this.lblProcedimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.bttguardar = new System.Windows.Forms.Button();
            this.errorMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtnumerodeidentificacion = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cbxprocedimiento = new System.Windows.Forms.ComboBox();
            this.cbxTipodedocumento = new System.Windows.Forms.ComboBox();
            this.lbltipodedocumento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRegresar
            // 
            this.bttRegresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttRegresar.Location = new System.Drawing.Point(529, 222);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(121, 54);
            this.bttRegresar.TabIndex = 13;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = false;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // txtHoracita
            // 
            this.txtHoracita.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHoracita.Location = new System.Drawing.Point(234, 244);
            this.txtHoracita.Name = "txtHoracita";
            this.txtHoracita.Size = new System.Drawing.Size(220, 20);
            this.txtHoracita.TabIndex = 9;
            this.txtHoracita.TextChanged += new System.EventHandler(this.txtHoracita_TextChanged);
            // 
            // lblHoracita
            // 
            this.lblHoracita.AutoSize = true;
            this.lblHoracita.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoracita.Location = new System.Drawing.Point(29, 246);
            this.lblHoracita.Name = "lblHoracita";
            this.lblHoracita.Size = new System.Drawing.Size(81, 18);
            this.lblHoracita.TabIndex = 8;
            this.lblHoracita.Text = "Hora cita";
            this.lblHoracita.Click += new System.EventHandler(this.lblHoracita_Click);
            // 
            // dtpFechacita
            // 
            this.dtpFechacita.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechacita.Location = new System.Drawing.Point(234, 195);
            this.dtpFechacita.Name = "dtpFechacita";
            this.dtpFechacita.Size = new System.Drawing.Size(220, 20);
            this.dtpFechacita.TabIndex = 7;
            this.dtpFechacita.ValueChanged += new System.EventHandler(this.dtpFechacita_ValueChanged);
            // 
            // lblFechacita
            // 
            this.lblFechacita.AutoSize = true;
            this.lblFechacita.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechacita.Location = new System.Drawing.Point(29, 197);
            this.lblFechacita.Name = "lblFechacita";
            this.lblFechacita.Size = new System.Drawing.Size(90, 18);
            this.lblFechacita.TabIndex = 6;
            this.lblFechacita.Text = "Fecha cita";
            this.lblFechacita.Click += new System.EventHandler(this.lblFechacita_Click);
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.AutoSize = true;
            this.lblProcedimiento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.Location = new System.Drawing.Point(29, 304);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(125, 18);
            this.lblProcedimiento.TabIndex = 10;
            this.lblProcedimiento.Text = "Procedimiento";
            this.lblProcedimiento.Click += new System.EventHandler(this.lblProcedimiento_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(29, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 18);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 90);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(212, 18);
            this.lblIdentificacion.TabIndex = 2;
            this.lblIdentificacion.Text = "Numero de Identificación";
            this.lblIdentificacion.Click += new System.EventHandler(this.lblIdentificacion_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombres.Location = new System.Drawing.Point(234, 18);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(220, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(26, 18);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(171, 18);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres completos";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // bttguardar
            // 
            this.bttguardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttguardar.Location = new System.Drawing.Point(529, 91);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(121, 57);
            this.bttguardar.TabIndex = 12;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = false;
            this.bttguardar.Click += new System.EventHandler(this.bttguardar_Click);
            // 
            // errorMensaje
            // 
            this.errorMensaje.ContainerControl = this;
            // 
            // mtxtnumerodeidentificacion
            // 
            this.mtxtnumerodeidentificacion.Location = new System.Drawing.Point(234, 91);
            this.mtxtnumerodeidentificacion.Mask = "0000000000";
            this.mtxtnumerodeidentificacion.Name = "mtxtnumerodeidentificacion";
            this.mtxtnumerodeidentificacion.Size = new System.Drawing.Size(220, 20);
            this.mtxtnumerodeidentificacion.TabIndex = 16;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(234, 136);
            this.mtxtTelefono.Mask = "0000000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(220, 20);
            this.mtxtTelefono.TabIndex = 17;
            // 
            // cbxprocedimiento
            // 
            this.cbxprocedimiento.FormattingEnabled = true;
            this.cbxprocedimiento.Items.AddRange(new object[] {
            "Ortodoncia estetica",
            "Diseño de sonrisa",
            "Blanqueamiento",
            "Implantes dentales",
            "Cirugia",
            "endodoncia",
            "Implantes",
            "Periodoncia"});
            this.cbxprocedimiento.Location = new System.Drawing.Point(234, 301);
            this.cbxprocedimiento.Name = "cbxprocedimiento";
            this.cbxprocedimiento.Size = new System.Drawing.Size(220, 21);
            this.cbxprocedimiento.TabIndex = 18;
            // 
            // cbxTipodedocumento
            // 
            this.cbxTipodedocumento.FormattingEnabled = true;
            this.cbxTipodedocumento.Items.AddRange(new object[] {
            "Cedula de ciudadania",
            "Tarjeta de identidad",
            "Cedula de extrangeria"});
            this.cbxTipodedocumento.Location = new System.Drawing.Point(234, 49);
            this.cbxTipodedocumento.Name = "cbxTipodedocumento";
            this.cbxTipodedocumento.Size = new System.Drawing.Size(220, 21);
            this.cbxTipodedocumento.TabIndex = 19;
            // 
            // lbltipodedocumento
            // 
            this.lbltipodedocumento.AutoSize = true;
            this.lbltipodedocumento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodedocumento.Location = new System.Drawing.Point(26, 52);
            this.lbltipodedocumento.Name = "lbltipodedocumento";
            this.lbltipodedocumento.Size = new System.Drawing.Size(163, 18);
            this.lbltipodedocumento.TabIndex = 20;
            this.lbltipodedocumento.Text = "Tipo de documento";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.sistema_sano_del_icono_del_diente_crema_dental_del_cepillo_de_dientes_personaje_de_dibujos_animados_97101768;
            this.ClientSize = new System.Drawing.Size(680, 376);
            this.Controls.Add(this.lbltipodedocumento);
            this.Controls.Add(this.cbxTipodedocumento);
            this.Controls.Add(this.cbxprocedimiento);
            this.Controls.Add(this.mtxtTelefono);
            this.Controls.Add(this.mtxtnumerodeidentificacion);
            this.Controls.Add(this.bttguardar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.txtHoracita);
            this.Controls.Add(this.lblHoracita);
            this.Controls.Add(this.dtpFechacita);
            this.Controls.Add(this.lblFechacita);
            this.Controls.Add(this.lblProcedimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblIdentificacion);
            this.Name = "Form2";
            this.Text = "Agenda de citas";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label lblProcedimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button bttguardar;
        private System.Windows.Forms.ErrorProvider errorMensaje;
        private System.Windows.Forms.ComboBox cbxprocedimiento;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.MaskedTextBox mtxtnumerodeidentificacion;
        private System.Windows.Forms.Label lbltipodedocumento;
        private System.Windows.Forms.ComboBox cbxTipodedocumento;
    }
}