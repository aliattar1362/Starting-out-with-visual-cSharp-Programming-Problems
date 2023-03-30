namespace Latin_Translator
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
            this.sinisterButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(110, 259);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(73, 59);
            this.sinisterButton.TabIndex = 0;
            this.sinisterButton.Text = "Translate \"Sinister\" to English";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(259, 259);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(73, 59);
            this.dexterButton.TabIndex = 1;
            this.dexterButton.Text = "Translate \"Dexter\" to English";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(404, 259);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(73, 59);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Translate \"Medium\" to English";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(209, 166);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(178, 20);
            this.displayTextBox.TabIndex = 3;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.sinisterButton);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

