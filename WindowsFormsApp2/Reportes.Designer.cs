namespace WindowsFormsApp2
{
    partial class Reportes
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
            this.bttregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttregresar
            // 
            this.bttregresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttregresar.Location = new System.Drawing.Point(116, 412);
            this.bttregresar.Name = "bttregresar";
            this.bttregresar.Size = new System.Drawing.Size(208, 34);
            this.bttregresar.TabIndex = 0;
            this.bttregresar.Text = "Regresar";
            this.bttregresar.UseVisualStyleBackColor = false;
            this.bttregresar.Click += new System.EventHandler(this.bttregresar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Captura;
            this.ClientSize = new System.Drawing.Size(438, 441);
            this.Controls.Add(this.bttregresar);
            this.Name = "Form4";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttregresar;
    }
}