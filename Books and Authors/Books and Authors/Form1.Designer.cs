namespace Books_and_Authors
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
            this.goneWithTheWindButton = new System.Windows.Forms.Button();
            this.rootsButton = new System.Windows.Forms.Button();
            this.atlasShruggedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goneWithTheWindButton
            // 
            this.goneWithTheWindButton.AutoSize = true;
            this.goneWithTheWindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goneWithTheWindButton.Location = new System.Drawing.Point(128, 163);
            this.goneWithTheWindButton.Name = "goneWithTheWindButton";
            this.goneWithTheWindButton.Size = new System.Drawing.Size(130, 50);
            this.goneWithTheWindButton.TabIndex = 0;
            this.goneWithTheWindButton.Text = "Gone with the Wind";
            this.goneWithTheWindButton.UseVisualStyleBackColor = true;
            this.goneWithTheWindButton.Click += new System.EventHandler(this.goneWithTheWindButton_Click);
            // 
            // rootsButton
            // 
            this.rootsButton.AutoSize = true;
            this.rootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootsButton.Location = new System.Drawing.Point(315, 163);
            this.rootsButton.Name = "rootsButton";
            this.rootsButton.Size = new System.Drawing.Size(99, 50);
            this.rootsButton.TabIndex = 1;
            this.rootsButton.Text = "Roots";
            this.rootsButton.UseVisualStyleBackColor = true;
            this.rootsButton.Click += new System.EventHandler(this.rootsButton_Click);
            // 
            // atlasShruggedButton
            // 
            this.atlasShruggedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atlasShruggedButton.Location = new System.Drawing.Point(482, 163);
            this.atlasShruggedButton.Name = "atlasShruggedButton";
            this.atlasShruggedButton.Size = new System.Drawing.Size(109, 49);
            this.atlasShruggedButton.TabIndex = 2;
            this.atlasShruggedButton.Text = "Atlas Shrugged";
            this.atlasShruggedButton.UseVisualStyleBackColor = true;
            this.atlasShruggedButton.Click += new System.EventHandler(this.atlasShruggedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Margaret Mitchell";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alex Haley";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ayn Rand";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atlasShruggedButton);
            this.Controls.Add(this.rootsButton);
            this.Controls.Add(this.goneWithTheWindButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goneWithTheWindButton;
        private System.Windows.Forms.Button rootsButton;
        private System.Windows.Forms.Button atlasShruggedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

