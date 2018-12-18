namespace ServerTcp
{
    partial class ServerForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.textrecibe = new System.Windows.Forms.Label();
            this.textmanda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(316, 146);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Label1";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(72, 55);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(35, 13);
            this.ServerLabel.TabIndex = 8;
            this.ServerLabel.Text = "label1";
            // 
            // textrecibe
            // 
            this.textrecibe.AutoSize = true;
            this.textrecibe.Location = new System.Drawing.Point(350, 215);
            this.textrecibe.Name = "textrecibe";
            this.textrecibe.Size = new System.Drawing.Size(36, 13);
            this.textrecibe.TabIndex = 13;
            this.textrecibe.Text = "recibe";
            // 
            // textmanda
            // 
            this.textmanda.AutoSize = true;
            this.textmanda.Location = new System.Drawing.Point(350, 243);
            this.textmanda.Name = "textmanda";
            this.textmanda.Size = new System.Drawing.Size(39, 13);
            this.textmanda.TabIndex = 12;
            this.textmanda.Text = "manda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "recibe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "manda";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textrecibe);
            this.Controls.Add(this.textmanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ServerLabel);
            this.Name = "ServerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label textrecibe;
        private System.Windows.Forms.Label textmanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

