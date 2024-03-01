namespace WindowsFormsVaja2
{
    partial class Form1
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
            this.dlgBarva = new System.Windows.Forms.ColorDialog();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnBarva = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(13, 14);
            this.txtVnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(397, 26);
            this.txtVnos.TabIndex = 0;
            // 
            // btnBarva
            // 
            this.btnBarva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBarva.Location = new System.Drawing.Point(13, 50);
            this.btnBarva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBarva.Name = "btnBarva";
            this.btnBarva.Size = new System.Drawing.Size(188, 35);
            this.btnBarva.TabIndex = 1;
            this.btnBarva.Text = "Barva";
            this.btnBarva.UseVisualStyleBackColor = true;
            this.btnBarva.Click += new System.EventHandler(this.SpremeniBarvo);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFont.Location = new System.Drawing.Point(222, 50);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(188, 35);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.SpremeniFont);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 94);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnBarva);
            this.Controls.Add(this.txtVnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog dlgBarva;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnBarva;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

