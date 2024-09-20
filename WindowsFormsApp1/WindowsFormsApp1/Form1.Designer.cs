namespace RangoNumeros
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
            this.Btmostrar = new System.Windows.Forms.Button();
            this.texBoxY = new System.Windows.Forms.TextBox();
            this.texBoxX = new System.Windows.Forms.TextBox();
            this.texBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btmostrar
            // 
            this.Btmostrar.Location = new System.Drawing.Point(298, 94);
            this.Btmostrar.Name = "Btmostrar";
            this.Btmostrar.Size = new System.Drawing.Size(75, 23);
            this.Btmostrar.TabIndex = 0;
            this.Btmostrar.Text = "Mostrar";
            this.Btmostrar.UseVisualStyleBackColor = true;
            this.Btmostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // texBoxY
            // 
            this.texBoxY.Location = new System.Drawing.Point(356, 38);
            this.texBoxY.Name = "texBoxY";
            this.texBoxY.Size = new System.Drawing.Size(126, 20);
            this.texBoxY.TabIndex = 1;
            // 
            // texBoxX
            // 
            this.texBoxX.Location = new System.Drawing.Point(182, 38);
            this.texBoxX.Name = "texBoxX";
            this.texBoxX.Size = new System.Drawing.Size(126, 20);
            this.texBoxX.TabIndex = 2;
            // 
            // texBoxResult
            // 
            this.texBoxResult.Location = new System.Drawing.Point(288, 152);
            this.texBoxResult.Multiline = true;
            this.texBoxResult.Name = "texBoxResult";
            this.texBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texBoxResult.Size = new System.Drawing.Size(100, 20);
            this.texBoxResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texBoxResult);
            this.Controls.Add(this.texBoxX);
            this.Controls.Add(this.texBoxY);
            this.Controls.Add(this.Btmostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btmostrar;
        private System.Windows.Forms.TextBox texBoxY;
        private System.Windows.Forms.TextBox texBoxX;
        private System.Windows.Forms.TextBox texBoxResult;
    }
}

