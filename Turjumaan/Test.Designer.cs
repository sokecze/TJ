namespace Turjumaan
{
    partial class Test
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
            this.textForeign = new System.Windows.Forms.RichTextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textNative = new System.Windows.Forms.RichTextBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.toolTipCheck = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSkip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // textForeign
            // 
            this.textForeign.BackColor = System.Drawing.SystemColors.Window;
            this.textForeign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textForeign.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textForeign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textForeign.Location = new System.Drawing.Point(12, 12);
            this.textForeign.Name = "textForeign";
            this.textForeign.ReadOnly = true;
            this.textForeign.Size = new System.Drawing.Size(602, 151);
            this.textForeign.TabIndex = 0;
            this.textForeign.TabStop = false;
            this.textForeign.Text = "";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(283, 331);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(160, 35);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "вперед";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            this.buttonCheck.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonCheck_KeyUp);
            // 
            // textNative
            // 
            this.textNative.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNative.Location = new System.Drawing.Point(12, 169);
            this.textNative.Multiline = false;
            this.textNative.Name = "textNative";
            this.textNative.Size = new System.Drawing.Size(602, 151);
            this.textNative.TabIndex = 1;
            this.textNative.Text = "";
            this.textNative.TextChanged += new System.EventHandler(this.textNative_TextChanged);
            this.textNative.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNative_KeyPress);
            this.textNative.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textNative_KeyUp);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::Turjumaan.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(581, 23);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(21, 21);
            this.picPlay.TabIndex = 3;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSkip.Location = new System.Drawing.Point(454, 331);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(160, 35);
            this.buttonSkip.TabIndex = 4;
            this.buttonSkip.Text = "пропустить";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 378);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.textNative);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textForeign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textForeign;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.RichTextBox textNative;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.ToolTip toolTipCheck;
        private System.Windows.Forms.ToolTip toolTipSkip;
    }
}