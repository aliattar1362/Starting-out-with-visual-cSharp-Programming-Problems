namespace Head_or_Tails
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
            this.headButton = new System.Windows.Forms.Button();
            this.tailButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tailPictureBox = new System.Windows.Forms.PictureBox();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headButton
            // 
            this.headButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headButton.Location = new System.Drawing.Point(160, 339);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(110, 51);
            this.headButton.TabIndex = 0;
            this.headButton.Text = "Show Heads";
            this.headButton.UseVisualStyleBackColor = true;
            this.headButton.Click += new System.EventHandler(this.headButton_Click);
            // 
            // tailButton
            // 
            this.tailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailButton.Location = new System.Drawing.Point(302, 339);
            this.tailButton.Name = "tailButton";
            this.tailButton.Size = new System.Drawing.Size(100, 51);
            this.tailButton.TabIndex = 1;
            this.tailButton.Text = "Show Tails";
            this.tailButton.UseVisualStyleBackColor = true;
            this.tailButton.Click += new System.EventHandler(this.tailButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tailPictureBox
            // 
            this.tailPictureBox.Image = global::Head_or_Tails.Properties.Resources.tail;
            this.tailPictureBox.Location = new System.Drawing.Point(373, 152);
            this.tailPictureBox.Name = "tailPictureBox";
            this.tailPictureBox.Size = new System.Drawing.Size(177, 148);
            this.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPictureBox.TabIndex = 5;
            this.tailPictureBox.TabStop = false;
            this.tailPictureBox.Visible = false;
            // 
            // headPictureBox
            // 
            this.headPictureBox.Image = global::Head_or_Tails.Properties.Resources.head;
            this.headPictureBox.Location = new System.Drawing.Point(160, 152);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(177, 148);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPictureBox.TabIndex = 3;
            this.headPictureBox.TabStop = false;
            this.headPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tailPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tailButton);
            this.Controls.Add(this.headButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button headButton;
        private System.Windows.Forms.Button tailButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailPictureBox;
    }
}

