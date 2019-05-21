namespace WindowsFormsApp2
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
            this.bttingresar = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblsonrisaperfecta = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bttingresar
            // 
            this.bttingresar.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttingresar.Location = new System.Drawing.Point(195, 276);
            this.bttingresar.Name = "bttingresar";
            this.bttingresar.Size = new System.Drawing.Size(105, 55);
            this.bttingresar.TabIndex = 5;
            this.bttingresar.Text = "Ingresar";
            this.bttingresar.UseVisualStyleBackColor = false;
            this.bttingresar.Click += new System.EventHandler(this.bttingresar_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.BackColor = System.Drawing.Color.DarkOrchid;
            this.bttSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttSalir.Location = new System.Drawing.Point(416, 276);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(109, 55);
            this.bttSalir.TabIndex = 6;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = false;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtusuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(416, 113);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(139, 29);
            this.txtusuario.TabIndex = 2;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtclave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(416, 167);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(139, 29);
            this.txtclave.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.SystemColors.Control;
            this.lblClave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(201, 167);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(62, 22);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(191, 113);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblsonrisaperfecta
            // 
            this.lblsonrisaperfecta.AutoSize = true;
            this.lblsonrisaperfecta.BackColor = System.Drawing.Color.BlueViolet;
            this.lblsonrisaperfecta.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsonrisaperfecta.Location = new System.Drawing.Point(63, 16);
            this.lblsonrisaperfecta.Name = "lblsonrisaperfecta";
            this.lblsonrisaperfecta.Size = new System.Drawing.Size(621, 71);
            this.lblsonrisaperfecta.TabIndex = 0;
            this.lblsonrisaperfecta.Text = "SONRISA PERFECTA";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 314);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._5fc49fbce20e0854ec8fc3b08e86838b;
            this.ClientSize = new System.Drawing.Size(744, 365);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblsonrisaperfecta);
            this.Controls.Add(this.bttingresar);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttingresar;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblsonrisaperfecta;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

