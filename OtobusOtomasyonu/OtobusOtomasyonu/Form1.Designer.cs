namespace OtobusOtomasyonu
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sakaryaİstanbulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 444);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sakaryaİstanbulToolStripMenuItem});
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            // 
            // sakaryaİstanbulToolStripMenuItem
            // 
            this.sakaryaİstanbulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.sakaryaİstanbulToolStripMenuItem.Name = "sakaryaİstanbulToolStripMenuItem";
            this.sakaryaİstanbulToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sakaryaİstanbulToolStripMenuItem.Text = "Sakarya-İstanbul";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "07:00",
            "09:00",
            "13:00",
            "20:00"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bayToolStripMenuItem,
            this.bayanToolStripMenuItem});
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            // 
            // bayToolStripMenuItem
            // 
            this.bayToolStripMenuItem.Name = "bayToolStripMenuItem";
            this.bayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bayToolStripMenuItem.Text = "Bay";
            this.bayToolStripMenuItem.Click += new System.EventHandler(this.bayToolStripMenuItem_Click);
            // 
            // bayanToolStripMenuItem
            // 
            this.bayanToolStripMenuItem.Name = "bayanToolStripMenuItem";
            this.bayanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bayanToolStripMenuItem.Text = "Bayan";
            this.bayanToolStripMenuItem.Click += new System.EventHandler(this.bayanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 424);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sakaryaİstanbulToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayanToolStripMenuItem;
    }
}

