namespace Nostsalgic_Songs
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
            this.songButton = new System.Windows.Forms.Button();
            this.artistButton = new System.Windows.Forms.Button();
            this.labelControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songButton
            // 
            this.songButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songButton.Location = new System.Drawing.Point(201, 145);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(102, 53);
            this.songButton.TabIndex = 0;
            this.songButton.Text = "Song";
            this.songButton.UseVisualStyleBackColor = true;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // artistButton
            // 
            this.artistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistButton.Location = new System.Drawing.Point(390, 146);
            this.artistButton.Name = "artistButton";
            this.artistButton.Size = new System.Drawing.Size(105, 52);
            this.artistButton.TabIndex = 1;
            this.artistButton.Text = "Artist";
            this.artistButton.UseVisualStyleBackColor = true;
            this.artistButton.Click += new System.EventHandler(this.artistButton_Click);
            // 
            // labelControl
            // 
            this.labelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl.Location = new System.Drawing.Point(236, 265);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(239, 46);
            this.labelControl.TabIndex = 2;
            this.labelControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.artistButton);
            this.Controls.Add(this.songButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button songButton;
        private System.Windows.Forms.Button artistButton;
        private System.Windows.Forms.Label labelControl;
    }
}

