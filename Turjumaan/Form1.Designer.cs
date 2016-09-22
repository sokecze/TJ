namespace Turjumaan
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaxNum = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonDictionary = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonGet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущий набор:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выучено:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaxNum
            // 
            this.labelMaxNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMaxNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxNum.Location = new System.Drawing.Point(0, 85);
            this.labelMaxNum.Name = "labelMaxNum";
            this.labelMaxNum.Size = new System.Drawing.Size(400, 18);
            this.labelMaxNum.TabIndex = 2;
            this.labelMaxNum.Text = "0";
            this.labelMaxNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNum
            // 
            this.labelNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(0, 171);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(400, 18);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "0";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDictionary
            // 
            this.buttonDictionary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDictionary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDictionary.Location = new System.Drawing.Point(12, 216);
            this.buttonDictionary.Name = "buttonDictionary";
            this.buttonDictionary.Size = new System.Drawing.Size(167, 69);
            this.buttonDictionary.TabIndex = 5;
            this.buttonDictionary.Text = "словарь";
            this.buttonDictionary.UseVisualStyleBackColor = false;
            this.buttonDictionary.Click += new System.EventHandler(this.buttonDictionary_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTest.Enabled = false;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.Location = new System.Drawing.Point(221, 216);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(167, 69);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "тестирование";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGet.Location = new System.Drawing.Point(152, 82);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(105, 26);
            this.buttonGet.TabIndex = 4;
            this.buttonGet.Text = "получить";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Visible = false;
            this.buttonGet.VisibleChanged += new System.EventHandler(this.buttonGet_VisibleChanged);
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 310);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonDictionary);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMaxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button buttonDictionary;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

