namespace ExpressPrint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Datoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.odpriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navpičnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodoravnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filitriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posvetliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potemniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOdpri = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(783, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 426);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 433);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(783, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datoteka,
            this.vrtenjeToolStripMenuItem,
            this.zrcaljenjeToolStripMenuItem,
            this.filitriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Datoteka
            // 
            this.Datoteka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odpriToolStripMenuItem,
            this.izhodToolStripMenuItem,
            this.shraniToolStripMenuItem});
            this.Datoteka.Name = "Datoteka";
            this.Datoteka.Size = new System.Drawing.Size(66, 20);
            this.Datoteka.Text = "Datoteka";
            // 
            // odpriToolStripMenuItem
            // 
            this.odpriToolStripMenuItem.Name = "odpriToolStripMenuItem";
            this.odpriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odpriToolStripMenuItem.Text = "Odpri";
            this.odpriToolStripMenuItem.Click += new System.EventHandler(this.odpriToolStripMenuItem_Click);
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izhodToolStripMenuItem.Text = "Shrani";
            // 
            // shraniToolStripMenuItem
            // 
            this.shraniToolStripMenuItem.Name = "shraniToolStripMenuItem";
            this.shraniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shraniToolStripMenuItem.Text = "Izhod";
            // 
            // vrtenjeToolStripMenuItem
            // 
            this.vrtenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.za90ToolStripMenuItem,
            this.za180ToolStripMenuItem,
            this.za270ToolStripMenuItem});
            this.vrtenjeToolStripMenuItem.Name = "vrtenjeToolStripMenuItem";
            this.vrtenjeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vrtenjeToolStripMenuItem.Text = "Vrtenje";
            // 
            // za90ToolStripMenuItem
            // 
            this.za90ToolStripMenuItem.Name = "za90ToolStripMenuItem";
            this.za90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za90ToolStripMenuItem.Text = "Za 90°";
            this.za90ToolStripMenuItem.Click += new System.EventHandler(this.za90ToolStripMenuItem_Click);
            // 
            // za180ToolStripMenuItem
            // 
            this.za180ToolStripMenuItem.Name = "za180ToolStripMenuItem";
            this.za180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za180ToolStripMenuItem.Text = "Za 180°";
            this.za180ToolStripMenuItem.Click += new System.EventHandler(this.za180ToolStripMenuItem_Click);
            // 
            // za270ToolStripMenuItem
            // 
            this.za270ToolStripMenuItem.Name = "za270ToolStripMenuItem";
            this.za270ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za270ToolStripMenuItem.Text = "Za 270°";
            this.za270ToolStripMenuItem.Click += new System.EventHandler(this.za270ToolStripMenuItem_Click);
            // 
            // zrcaljenjeToolStripMenuItem
            // 
            this.zrcaljenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navpičnoToolStripMenuItem,
            this.vodoravnoToolStripMenuItem});
            this.zrcaljenjeToolStripMenuItem.Name = "zrcaljenjeToolStripMenuItem";
            this.zrcaljenjeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zrcaljenjeToolStripMenuItem.Text = "Zrcaljenje";
            // 
            // navpičnoToolStripMenuItem
            // 
            this.navpičnoToolStripMenuItem.Name = "navpičnoToolStripMenuItem";
            this.navpičnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navpičnoToolStripMenuItem.Text = "Navpično";
            this.navpičnoToolStripMenuItem.Click += new System.EventHandler(this.navpičnoToolStripMenuItem_Click);
            // 
            // vodoravnoToolStripMenuItem
            // 
            this.vodoravnoToolStripMenuItem.Name = "vodoravnoToolStripMenuItem";
            this.vodoravnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vodoravnoToolStripMenuItem.Text = "Vodoravno";
            this.vodoravnoToolStripMenuItem.Click += new System.EventHandler(this.vodoravnoToolStripMenuItem_Click);
            // 
            // filitriToolStripMenuItem
            // 
            this.filitriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posvetliToolStripMenuItem,
            this.potemniToolStripMenuItem,
            this.negativToolStripMenuItem});
            this.filitriToolStripMenuItem.Name = "filitriToolStripMenuItem";
            this.filitriToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filitriToolStripMenuItem.Text = "Filitri";
            // 
            // posvetliToolStripMenuItem
            // 
            this.posvetliToolStripMenuItem.Name = "posvetliToolStripMenuItem";
            this.posvetliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.posvetliToolStripMenuItem.Text = "Posvetli";
            this.posvetliToolStripMenuItem.Click += new System.EventHandler(this.posvetliToolStripMenuItem_Click);
            // 
            // potemniToolStripMenuItem
            // 
            this.potemniToolStripMenuItem.Name = "potemniToolStripMenuItem";
            this.potemniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.potemniToolStripMenuItem.Text = "Potemni";
            this.potemniToolStripMenuItem.Click += new System.EventHandler(this.potemniToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // dlgOdpri
            // 
            this.dlgOdpri.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Datoteka;
        private System.Windows.Forms.ToolStripMenuItem odpriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navpičnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodoravnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filitriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posvetliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potemniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOdpri;
    }
}

