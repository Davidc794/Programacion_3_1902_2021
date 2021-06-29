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
            this.Ordenarbutton = new System.Windows.Forms.Button();
            this.OrdenarlistBox = new System.Windows.Forms.ListBox();
            this.MaxiMinbutton = new System.Windows.Forms.Button();
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
            this.DiaslistBox.Size = new System.Drawing.Size(105, 121);
            this.DiaslistBox.TabIndex = 1;
            // 
            // SemanalistBox
            // 
            this.SemanalistBox.FormattingEnabled = true;
            this.SemanalistBox.Location = new System.Drawing.Point(150, 128);
            this.SemanalistBox.Name = "SemanalistBox";
            this.SemanalistBox.Size = new System.Drawing.Size(127, 121);
            this.SemanalistBox.TabIndex = 2;
            // 
            // Ordenarbutton
            // 
            this.Ordenarbutton.Location = new System.Drawing.Point(208, 11);
            this.Ordenarbutton.Name = "Ordenarbutton";
            this.Ordenarbutton.Size = new System.Drawing.Size(120, 80);
            this.Ordenarbutton.TabIndex = 3;
            this.Ordenarbutton.Text = "Ordenar";
            this.Ordenarbutton.UseVisualStyleBackColor = true;
            this.Ordenarbutton.Click += new System.EventHandler(this.Ordenarbutton_Click);
            // 
            // OrdenarlistBox
            // 
            this.OrdenarlistBox.FormattingEnabled = true;
            this.OrdenarlistBox.Location = new System.Drawing.Point(329, 128);
            this.OrdenarlistBox.Name = "OrdenarlistBox";
            this.OrdenarlistBox.Size = new System.Drawing.Size(112, 121);
            this.OrdenarlistBox.TabIndex = 4;
            // 
            // MaxiMinbutton
            // 
            this.MaxiMinbutton.Location = new System.Drawing.Point(366, 11);
            this.MaxiMinbutton.Name = "MaxiMinbutton";
            this.MaxiMinbutton.Size = new System.Drawing.Size(103, 80);
            this.MaxiMinbutton.TabIndex = 5;
            this.MaxiMinbutton.Text = "MaximoMinim";
            this.MaxiMinbutton.UseVisualStyleBackColor = true;
            this.MaxiMinbutton.Click += new System.EventHandler(this.MaxiMinbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.MaxiMinbutton);
            this.Controls.Add(this.OrdenarlistBox);
            this.Controls.Add(this.Ordenarbutton);
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
        private System.Windows.Forms.Button Ordenarbutton;
        private System.Windows.Forms.ListBox OrdenarlistBox;
        private System.Windows.Forms.Button MaxiMinbutton;
    }
}

