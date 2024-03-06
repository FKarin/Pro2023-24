namespace ARGB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImeBarve = new System.Windows.Forms.TextBox();
            this.btnOzadje = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOspredje = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOzadje);
            this.groupBox1.Controls.Add(this.txtImeBarve);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(15, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(435, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ime barve";
            // 
            // txtImeBarve
            // 
            this.txtImeBarve.Location = new System.Drawing.Point(9, 41);
            this.txtImeBarve.Name = "txtImeBarve";
            this.txtImeBarve.Size = new System.Drawing.Size(222, 29);
            this.txtImeBarve.TabIndex = 0;
            // 
            // btnOzadje
            // 
            this.btnOzadje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOzadje.Location = new System.Drawing.Point(252, 41);
            this.btnOzadje.Name = "btnOzadje";
            this.btnOzadje.Size = new System.Drawing.Size(174, 29);
            this.btnOzadje.TabIndex = 1;
            this.btnOzadje.Text = "Nastavi ozadje";
            this.btnOzadje.UseVisualStyleBackColor = true;
            this.btnOzadje.Click += new System.EventHandler(this.btnOzadje_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.txtG);
            this.groupBox2.Controls.Add(this.txtR);
            this.groupBox2.Controls.Add(this.btnOspredje);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(15, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(435, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barva iz ARGB";
            // 
            // btnOspredje
            // 
            this.btnOspredje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOspredje.Location = new System.Drawing.Point(252, 41);
            this.btnOspredje.Name = "btnOspredje";
            this.btnOspredje.Size = new System.Drawing.Size(174, 29);
            this.btnOspredje.TabIndex = 1;
            this.btnOspredje.Text = "Nastavi ospredje";
            this.btnOspredje.UseVisualStyleBackColor = true;
            this.btnOspredje.Click += new System.EventHandler(this.btnOspredje_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(9, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(51, 29);
            this.txtA.TabIndex = 0;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(66, 41);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(51, 29);
            this.txtR.TabIndex = 2;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(123, 41);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(51, 29);
            this.txtG.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(180, 41);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(51, 29);
            this.txtB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOzadje;
        private System.Windows.Forms.TextBox txtImeBarve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnOspredje;
        private System.Windows.Forms.TextBox txtA;
    }
}

