namespace Orion_Constellation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.starNamesButton = new System.Windows.Forms.Button();
            this.hideNamesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Orion_Constellation.Properties.Resources.Orion;
            this.pictureBox1.Location = new System.Drawing.Point(163, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Location = new System.Drawing.Point(198, 53);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(60, 13);
            this.betelgeuseLabel.TabIndex = 1;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Location = new System.Drawing.Point(400, 97);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(40, 13);
            this.meissaLabel.TabIndex = 2;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Location = new System.Drawing.Point(375, 255);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(45, 13);
            this.mintakaLabel.TabIndex = 3;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Location = new System.Drawing.Point(304, 217);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(40, 13);
            this.alnilamLabel.TabIndex = 4;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Location = new System.Drawing.Point(233, 246);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(39, 13);
            this.alnitakLabel.TabIndex = 5;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Location = new System.Drawing.Point(210, 394);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(34, 13);
            this.saiphLabel.TabIndex = 6;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Location = new System.Drawing.Point(409, 367);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(31, 13);
            this.rigelLabel.TabIndex = 7;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // starNamesButton
            // 
            this.starNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starNamesButton.Location = new System.Drawing.Point(135, 503);
            this.starNamesButton.Name = "starNamesButton";
            this.starNamesButton.Size = new System.Drawing.Size(84, 47);
            this.starNamesButton.TabIndex = 8;
            this.starNamesButton.Text = "Show Star Names";
            this.starNamesButton.UseVisualStyleBackColor = true;
            this.starNamesButton.Click += new System.EventHandler(this.starNamesButton_Click);
            // 
            // hideNamesButton
            // 
            this.hideNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideNamesButton.Location = new System.Drawing.Point(307, 503);
            this.hideNamesButton.Name = "hideNamesButton";
            this.hideNamesButton.Size = new System.Drawing.Size(84, 47);
            this.hideNamesButton.TabIndex = 9;
            this.hideNamesButton.Text = "Hide Star Names";
            this.hideNamesButton.UseVisualStyleBackColor = true;
            this.hideNamesButton.Click += new System.EventHandler(this.hideNamesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(447, 503);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 47);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideNamesButton);
            this.Controls.Add(this.starNamesButton);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.Button starNamesButton;
        private System.Windows.Forms.Button hideNamesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

