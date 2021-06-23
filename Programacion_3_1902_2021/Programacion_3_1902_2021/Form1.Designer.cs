namespace Programacion_3_1902_2021
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.DiaslistBox = new System.Windows.Forms.ListBox();
            this.SemanalistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(34, 12);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(134, 79);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // DiaslistBox
            // 
            this.DiaslistBox.FormattingEnabled = true;
            this.DiaslistBox.Location = new System.Drawing.Point(12, 128);
            this.DiaslistBox.Name = "DiaslistBox";
            this.DiaslistBox.Size = new System.Drawing.Size(156, 121);
            this.DiaslistBox.TabIndex = 1;
            // 
            // SemanalistBox
            // 
            this.SemanalistBox.FormattingEnabled = true;
            this.SemanalistBox.Location = new System.Drawing.Point(187, 128);
            this.SemanalistBox.Name = "SemanalistBox";
            this.SemanalistBox.Size = new System.Drawing.Size(159, 121);
            this.SemanalistBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.SemanalistBox);
            this.Controls.Add(this.DiaslistBox);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.ListBox DiaslistBox;
        private System.Windows.Forms.ListBox SemanalistBox;
    }
}

