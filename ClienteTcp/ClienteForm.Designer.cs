namespace ClienteTcp
{
    partial class ClienteForm
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
            this.sendBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textmanda = new System.Windows.Forms.Label();
            this.textrecibe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendBox
            // 
            this.sendBox.Location = new System.Drawing.Point(206, 69);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(100, 20);
            this.sendBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(669, 377);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connectar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "manda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "recibe";
            // 
            // textmanda
            // 
            this.textmanda.AutoSize = true;
            this.textmanda.Location = new System.Drawing.Point(320, 216);
            this.textmanda.Name = "textmanda";
            this.textmanda.Size = new System.Drawing.Size(39, 13);
            this.textmanda.TabIndex = 5;
            this.textmanda.Text = "manda";
            // 
            // textrecibe
            // 
            this.textrecibe.AutoSize = true;
            this.textrecibe.Location = new System.Drawing.Point(320, 254);
            this.textrecibe.Name = "textrecibe";
            this.textrecibe.Size = new System.Drawing.Size(36, 13);
            this.textrecibe.TabIndex = 6;
            this.textrecibe.Text = "recibe";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textrecibe);
            this.Controls.Add(this.textmanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBox);
            this.Name = "ClienteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textmanda;
        private System.Windows.Forms.Label textrecibe;
    }
}

