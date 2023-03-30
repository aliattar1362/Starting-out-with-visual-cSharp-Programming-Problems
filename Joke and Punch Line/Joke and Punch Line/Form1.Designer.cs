namespace Joke_and_Punch_Line
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Location = new System.Drawing.Point(201, 185);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(194, 23);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(201, 252);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 1;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(320, 252);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(75, 23);
            this.punchLineButton.TabIndex = 2;
            this.punchLineButton.Text = "Punch Line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.displayLabel);
            this.Name = "Form1";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchLineButton;
    }
}

