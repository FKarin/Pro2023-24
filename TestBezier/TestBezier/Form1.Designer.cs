namespace TestBezier
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
            this.bKontrolnik1 = new BezierKrivulja.bKontrolnik();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radT4 = new System.Windows.Forms.RadioButton();
            this.radT2 = new System.Windows.Forms.RadioButton();
            this.radT3 = new System.Windows.Forms.RadioButton();
            this.radT1 = new System.Windows.Forms.RadioButton();
            this.xTrack = new System.Windows.Forms.TrackBar();
            this.yTrack = new System.Windows.Forms.TrackBar();
            this.yText = new System.Windows.Forms.TextBox();
            this.xText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // bKontrolnik1
            // 
            this.bKontrolnik1.Location = new System.Drawing.Point(81, 144);
            this.bKontrolnik1.Margin = new System.Windows.Forms.Padding(12);
            this.bKontrolnik1.MaximumSize = new System.Drawing.Size(200, 200);
            this.bKontrolnik1.MinimumSize = new System.Drawing.Size(200, 200);
            this.bKontrolnik1.Name = "bKontrolnik1";
            this.bKontrolnik1.Size = new System.Drawing.Size(200, 200);
            this.bKontrolnik1.T1 = new System.Drawing.Point(0, 0);
            this.bKontrolnik1.T2 = new System.Drawing.Point(10, 30);
            this.bKontrolnik1.T3 = new System.Drawing.Point(50, 20);
            this.bKontrolnik1.T4 = new System.Drawing.Point(100, 40);
            this.bKontrolnik1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radT4);
            this.groupBox1.Controls.Add(this.radT2);
            this.groupBox1.Controls.Add(this.radT3);
            this.groupBox1.Controls.Add(this.radT1);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Točke";
            // 
            // radT4
            // 
            this.radT4.AutoSize = true;
            this.radT4.Location = new System.Drawing.Point(132, 67);
            this.radT4.Name = "radT4";
            this.radT4.Size = new System.Drawing.Size(54, 30);
            this.radT4.TabIndex = 3;
            this.radT4.Text = "T4";
            this.radT4.UseVisualStyleBackColor = true;
            this.radT4.CheckedChanged += new System.EventHandler(this.radT4_CheckedChanged);
            // 
            // radT2
            // 
            this.radT2.AutoSize = true;
            this.radT2.Location = new System.Drawing.Point(132, 31);
            this.radT2.Name = "radT2";
            this.radT2.Size = new System.Drawing.Size(54, 30);
            this.radT2.TabIndex = 2;
            this.radT2.Text = "T2";
            this.radT2.UseVisualStyleBackColor = true;
            this.radT2.CheckedChanged += new System.EventHandler(this.radT2_CheckedChanged);
            // 
            // radT3
            // 
            this.radT3.AutoSize = true;
            this.radT3.Location = new System.Drawing.Point(6, 67);
            this.radT3.Name = "radT3";
            this.radT3.Size = new System.Drawing.Size(54, 30);
            this.radT3.TabIndex = 1;
            this.radT3.Text = "T3";
            this.radT3.UseVisualStyleBackColor = true;
            this.radT3.CheckedChanged += new System.EventHandler(this.radT3_CheckedChanged);
            // 
            // radT1
            // 
            this.radT1.AutoSize = true;
            this.radT1.Checked = true;
            this.radT1.Location = new System.Drawing.Point(6, 31);
            this.radT1.Name = "radT1";
            this.radT1.Size = new System.Drawing.Size(54, 30);
            this.radT1.TabIndex = 0;
            this.radT1.TabStop = true;
            this.radT1.Text = "T1";
            this.radT1.UseVisualStyleBackColor = true;
            this.radT1.CheckedChanged += new System.EventHandler(this.radT1_CheckedChanged);
            // 
            // xTrack
            // 
            this.xTrack.Location = new System.Drawing.Point(81, 350);
            this.xTrack.Maximum = 200;
            this.xTrack.Name = "xTrack";
            this.xTrack.Size = new System.Drawing.Size(200, 45);
            this.xTrack.TabIndex = 2;
            this.xTrack.TickFrequency = 10;
            this.xTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.xTrack.Scroll += new System.EventHandler(this.xTrack_Scroll);
            // 
            // yTrack
            // 
            this.yTrack.Location = new System.Drawing.Point(31, 144);
            this.yTrack.Maximum = 200;
            this.yTrack.Name = "yTrack";
            this.yTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.yTrack.Size = new System.Drawing.Size(45, 200);
            this.yTrack.TabIndex = 3;
            this.yTrack.TickFrequency = 10;
            this.yTrack.Value = 200;
            this.yTrack.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(13, 350);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(63, 32);
            this.yText.TabIndex = 4;
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(145, 388);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(64, 32);
            this.xText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 431);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.yTrack);
            this.Controls.Add(this.xTrack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bKontrolnik1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BezierKrivulja.bKontrolnik bKontrolnik1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radT4;
        private System.Windows.Forms.RadioButton radT2;
        private System.Windows.Forms.RadioButton radT3;
        private System.Windows.Forms.RadioButton radT1;
        private System.Windows.Forms.TrackBar xTrack;
        private System.Windows.Forms.TrackBar yTrack;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.TextBox xText;
    }
}

