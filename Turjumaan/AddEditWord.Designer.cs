namespace Turjumaan
{
    partial class AddEditWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExmpls = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAudio = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Английский:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEng.Location = new System.Drawing.Point(93, 35);
            this.textBoxEng.MaxLength = 60;
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(176, 21);
            this.textBoxEng.TabIndex = 0;
            this.textBoxEng.TextChanged += new System.EventHandler(this.textBoxEng_TextChanged);
            this.textBoxEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEng_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Русский:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxRu
            // 
            this.textBoxRu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRu.Location = new System.Drawing.Point(93, 95);
            this.textBoxRu.MaxLength = 60;
            this.textBoxRu.Name = "textBoxRu";
            this.textBoxRu.Size = new System.Drawing.Size(176, 21);
            this.textBoxRu.TabIndex = 1;
            this.textBoxRu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRu_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Примеры использования:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxExmpls
            // 
            this.textBoxExmpls.AcceptsReturn = true;
            this.textBoxExmpls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExmpls.Location = new System.Drawing.Point(93, 156);
            this.textBoxExmpls.Multiline = true;
            this.textBoxExmpls.Name = "textBoxExmpls";
            this.textBoxExmpls.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExmpls.Size = new System.Drawing.Size(176, 89);
            this.textBoxExmpls.TabIndex = 2;
            this.textBoxExmpls.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExmpls_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Аудиофайл";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAudio
            // 
            this.labelAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAudio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAudio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAudio.Location = new System.Drawing.Point(1, 281);
            this.labelAudio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAudio.Size = new System.Drawing.Size(368, 19);
            this.labelAudio.TabIndex = 3;
            this.labelAudio.Text = "(none)";
            this.labelAudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAudio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAudio_MouseDown);
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(73, 313);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(71, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(218, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(215, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "(X)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // AddEditWord
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(370, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAudio);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxExmpls);
            this.Controls.Add(this.textBoxRu);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditWord";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditWord";
            this.Load += new System.EventHandler(this.AddEditWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxRu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxExmpls;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
    }
}