namespace PrvoOkno
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrvo = new System.Windows.Forms.TextBox();
            this.txtDrugo = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSeštej = new System.Windows.Forms.RadioButton();
            this.radOdštej = new System.Windows.Forms.RadioButton();
            this.radMnoži = new System.Windows.Forms.RadioButton();
            this.radDeli = new System.Windows.Forms.RadioButton();
            this.chkNeg = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "mojGumb";
            this.button1.Location = new System.Drawing.Point(21, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Seštej);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prvo število";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drugo število";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rezultat";
            // 
            // txtPrvo
            // 
            this.txtPrvo.AccessibleName = "txtPrvo";
            this.txtPrvo.Location = new System.Drawing.Point(206, 21);
            this.txtPrvo.Name = "txtPrvo";
            this.txtPrvo.Size = new System.Drawing.Size(100, 29);
            this.txtPrvo.TabIndex = 4;
            // 
            // txtDrugo
            // 
            this.txtDrugo.AccessibleName = "txtDrugo";
            this.txtDrugo.Location = new System.Drawing.Point(206, 74);
            this.txtDrugo.Name = "txtDrugo";
            this.txtDrugo.Size = new System.Drawing.Size(100, 29);
            this.txtDrugo.TabIndex = 5;
            // 
            // txtRezultat
            // 
            this.txtRezultat.AccessibleName = "txtRezultat";
            this.txtRezultat.Location = new System.Drawing.Point(206, 127);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 29);
            this.txtRezultat.TabIndex = 6;
            this.txtRezultat.TabStop = false;
            // 
            // button2
            // 
            this.button2.AccessibleName = "mojGumb";
            this.button2.Location = new System.Drawing.Point(191, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "Počisti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDeli);
            this.groupBox1.Controls.Add(this.radMnoži);
            this.groupBox1.Controls.Add(this.radOdštej);
            this.groupBox1.Controls.Add(this.radSeštej);
            this.groupBox1.Location = new System.Drawing.Point(325, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacije";
            // 
            // radSeštej
            // 
            this.radSeštej.AutoSize = true;
            this.radSeštej.Checked = true;
            this.radSeštej.Location = new System.Drawing.Point(26, 28);
            this.radSeštej.Name = "radSeštej";
            this.radSeštej.Size = new System.Drawing.Size(120, 28);
            this.radSeštej.TabIndex = 0;
            this.radSeštej.TabStop = true;
            this.radSeštej.Text = "Seštevanje";
            this.radSeštej.UseVisualStyleBackColor = true;
            // 
            // radOdštej
            // 
            this.radOdštej.AutoSize = true;
            this.radOdštej.Location = new System.Drawing.Point(26, 62);
            this.radOdštej.Name = "radOdštej";
            this.radOdštej.Size = new System.Drawing.Size(123, 28);
            this.radOdštej.TabIndex = 1;
            this.radOdštej.Text = "Odštevanje";
            this.radOdštej.UseVisualStyleBackColor = true;
            // 
            // radMnoži
            // 
            this.radMnoži.AutoSize = true;
            this.radMnoži.Location = new System.Drawing.Point(26, 96);
            this.radMnoži.Name = "radMnoži";
            this.radMnoži.Size = new System.Drawing.Size(112, 28);
            this.radMnoži.TabIndex = 2;
            this.radMnoži.Text = "Množenje";
            this.radMnoži.UseVisualStyleBackColor = true;
            // 
            // radDeli
            // 
            this.radDeli.AutoSize = true;
            this.radDeli.Location = new System.Drawing.Point(26, 130);
            this.radDeli.Name = "radDeli";
            this.radDeli.Size = new System.Drawing.Size(97, 28);
            this.radDeli.TabIndex = 3;
            this.radDeli.Text = "Deljenje";
            this.radDeli.UseVisualStyleBackColor = true;
            // 
            // chkNeg
            // 
            this.chkNeg.AutoSize = true;
            this.chkNeg.Location = new System.Drawing.Point(325, 195);
            this.chkNeg.Name = "chkNeg";
            this.chkNeg.Size = new System.Drawing.Size(217, 52);
            this.chkNeg.TabIndex = 10;
            this.chkNeg.Text = "Obarvaj če je vrednost\r\nnegativna.";
            this.chkNeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 266);
            this.Controls.Add(this.chkNeg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtDrugo);
            this.Controls.Add(this.txtPrvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Prvo okno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrvo;
        private System.Windows.Forms.TextBox txtDrugo;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDeli;
        private System.Windows.Forms.RadioButton radMnoži;
        private System.Windows.Forms.RadioButton radOdštej;
        private System.Windows.Forms.RadioButton radSeštej;
        private System.Windows.Forms.CheckBox chkNeg;
    }
}

