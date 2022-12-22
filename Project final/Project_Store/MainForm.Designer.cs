namespace Project_Store
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編輯課程資訊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目類別分類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用者賬號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編輯課程資訊ToolStripMenuItem,
            this.科目類別分類ToolStripMenuItem,
            this.使用者賬號ToolStripMenuItem,
            this.登出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編輯課程資訊ToolStripMenuItem
            // 
            this.編輯課程資訊ToolStripMenuItem.Name = "編輯課程資訊ToolStripMenuItem";
            this.編輯課程資訊ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.編輯課程資訊ToolStripMenuItem.Text = "編輯科目資訊";
            this.編輯課程資訊ToolStripMenuItem.Click += new System.EventHandler(this.編輯課程資訊ToolStripMenuItem_Click);
            // 
            // 科目類別分類ToolStripMenuItem
            // 
            this.科目類別分類ToolStripMenuItem.Name = "科目類別分類ToolStripMenuItem";
            this.科目類別分類ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.科目類別分類ToolStripMenuItem.Text = "科目類別分類";
            this.科目類別分類ToolStripMenuItem.Click += new System.EventHandler(this.科目類別分類ToolStripMenuItem_Click);
            // 
            // 使用者賬號ToolStripMenuItem
            // 
            this.使用者賬號ToolStripMenuItem.Name = "使用者賬號ToolStripMenuItem";
            this.使用者賬號ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.使用者賬號ToolStripMenuItem.Text = "使用者賬號";
            this.使用者賬號ToolStripMenuItem.Click += new System.EventHandler(this.使用者賬號ToolStripMenuItem_Click);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.登出ToolStripMenuItem.Text = "登出";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 481);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編輯課程資訊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目類別分類ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用者賬號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
    }
}