namespace Caesar_shift
{
    partial class CaesarShift
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
            this.shiftCountBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.decipherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decipherAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shiftCountBox
            // 
            this.shiftCountBox.Location = new System.Drawing.Point(12, 69);
            this.shiftCountBox.Name = "shiftCountBox";
            this.shiftCountBox.Size = new System.Drawing.Size(59, 20);
            this.shiftCountBox.TabIndex = 0;
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(98, 69);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeBox.Size = new System.Drawing.Size(500, 300);
            this.codeBox.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(630, 69);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(500, 300);
            this.outputBox.TabIndex = 2;
            // 
            // decipherBtn
            // 
            this.decipherBtn.Location = new System.Drawing.Point(630, 415);
            this.decipherBtn.Name = "decipherBtn";
            this.decipherBtn.Size = new System.Drawing.Size(75, 23);
            this.decipherBtn.TabIndex = 3;
            this.decipherBtn.Text = "Decipher";
            this.decipherBtn.UseVisualStyleBackColor = true;
            this.decipherBtn.Click += new System.EventHandler(this.decipherBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shift Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deciphered Text";
            // 
            // decipherAllBtn
            // 
            this.decipherAllBtn.Location = new System.Drawing.Point(523, 415);
            this.decipherAllBtn.Name = "decipherAllBtn";
            this.decipherAllBtn.Size = new System.Drawing.Size(75, 23);
            this.decipherAllBtn.TabIndex = 7;
            this.decipherAllBtn.Text = "Decipher All";
            this.decipherAllBtn.UseVisualStyleBackColor = true;
            this.decipherAllBtn.Click += new System.EventHandler(this.decipherAllBtn_Click);
            // 
            // CaesarShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.decipherAllBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decipherBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.shiftCountBox);
            this.Name = "CaesarShift";
            this.Text = "Caesar Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shiftCountBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button decipherBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decipherAllBtn;
    }
}

