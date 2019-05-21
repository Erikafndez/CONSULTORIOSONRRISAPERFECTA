namespace WindowsFormsApp2
{
    partial class tratamientomedico
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
            this.txtcuidados = new System.Windows.Forms.TextBox();
            this.txtcostos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCuidadosespeciales = new System.Windows.Forms.Label();
            this.lblCostos = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bttguardar = new System.Windows.Forms.Button();
            this.errorMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRegresar
            // 
            this.bttRegresar.BackColor = System.Drawing.Color.DarkCyan;
            this.bttRegresar.Location = new System.Drawing.Point(173, 281);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(90, 63);
            this.bttRegresar.TabIndex = 83;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = false;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // txtcuidados
            // 
            this.txtcuidados.Location = new System.Drawing.Point(476, 179);
            this.txtcuidados.Name = "txtcuidados";
            this.txtcuidados.Size = new System.Drawing.Size(100, 20);
            this.txtcuidados.TabIndex = 82;
            // 
            // txtcostos
            // 
            this.txtcostos.Location = new System.Drawing.Point(163, 179);
            this.txtcostos.Name = "txtcostos";
            this.txtcostos.Size = new System.Drawing.Size(100, 20);
            this.txtcostos.TabIndex = 81;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(445, 63);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 80;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 78;
            // 
            // lblCuidadosespeciales
            // 
            this.lblCuidadosespeciales.AutoSize = true;
            this.lblCuidadosespeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuidadosespeciales.Location = new System.Drawing.Point(314, 180);
            this.lblCuidadosespeciales.Name = "lblCuidadosespeciales";
            this.lblCuidadosespeciales.Size = new System.Drawing.Size(156, 16);
            this.lblCuidadosespeciales.TabIndex = 77;
            this.lblCuidadosespeciales.Text = "Cuidados Especiales";
            // 
            // lblCostos
            // 
            this.lblCostos.AutoSize = true;
            this.lblCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostos.Location = new System.Drawing.Point(12, 185);
            this.lblCostos.Name = "lblCostos";
            this.lblCostos.Size = new System.Drawing.Size(151, 16);
            this.lblCostos.TabIndex = 76;
            this.lblCostos.Text = "Costos Aproximados";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(314, 67);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 16);
            this.lblDescripcion.TabIndex = 75;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(-2, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(170, 16);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre del tratamiento";
            // 
            // bttguardar
            // 
            this.bttguardar.BackColor = System.Drawing.Color.DarkCyan;
            this.bttguardar.Location = new System.Drawing.Point(317, 281);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(87, 63);
            this.bttguardar.TabIndex = 88;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = false;
            this.bttguardar.Click += new System.EventHandler(this.bttguardar_Click);
            // 
            // errorMensaje
            // 
            this.errorMensaje.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.images2;
            this.ClientSize = new System.Drawing.Size(588, 387);
            this.Controls.Add(this.bttguardar);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.txtcuidados);
            this.Controls.Add(this.txtcostos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCuidadosespeciales);
            this.Controls.Add(this.lblCostos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form4";
            this.Text = "Tratamiento a realizar";
            ((System.ComponentModel.ISupportInitialize)(this.errorMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRegresar;
        private System.Windows.Forms.TextBox txtcuidados;
        private System.Windows.Forms.TextBox txtcostos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCuidadosespeciales;
        private System.Windows.Forms.Label lblCostos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bttguardar;
        private System.Windows.Forms.ErrorProvider errorMensaje;
    }
}