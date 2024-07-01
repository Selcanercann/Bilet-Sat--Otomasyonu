namespace projeodevigorselprogramlama
{
    partial class koltuklar
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
            this.Travego = new System.Windows.Forms.Button();
            this.Setra = new System.Windows.Forms.Button();
            this.Neoplan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Travego
            // 
            this.Travego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Travego.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Travego.Location = new System.Drawing.Point(88, 358);
            this.Travego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Travego.Name = "Travego";
            this.Travego.Size = new System.Drawing.Size(147, 48);
            this.Travego.TabIndex = 0;
            this.Travego.Text = "Travego";
            this.Travego.UseVisualStyleBackColor = false;
            this.Travego.Click += new System.EventHandler(this.Travego_Click);
            // 
            // Setra
            // 
            this.Setra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Setra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Setra.Location = new System.Drawing.Point(309, 358);
            this.Setra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Setra.Name = "Setra";
            this.Setra.Size = new System.Drawing.Size(147, 48);
            this.Setra.TabIndex = 1;
            this.Setra.Text = "Setra";
            this.Setra.UseVisualStyleBackColor = false;
            this.Setra.Click += new System.EventHandler(this.Setra_Click);
            // 
            // Neoplan
            // 
            this.Neoplan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Neoplan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Neoplan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Neoplan.Location = new System.Drawing.Point(543, 358);
            this.Neoplan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Neoplan.Name = "Neoplan";
            this.Neoplan.Size = new System.Drawing.Size(147, 48);
            this.Neoplan.TabIndex = 2;
            this.Neoplan.Text = "Neoplan";
            this.Neoplan.UseVisualStyleBackColor = false;
            this.Neoplan.Click += new System.EventHandler(this.Neoplan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeodevigorselprogramlama.Properties.Resources._9ac2edc103c4996797bce7a2c45acc131;
            this.pictureBox1.Location = new System.Drawing.Point(64, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.anasayfa.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__17_;
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfa.Location = new System.Drawing.Point(755, 358);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(105, 48);
            this.anasayfa.TabIndex = 84;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // koltuklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 449);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Neoplan);
            this.Controls.Add(this.Setra);
            this.Controls.Add(this.Travego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "koltuklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Tipi";
            this.Load += new System.EventHandler(this.koltuklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Travego;
        private System.Windows.Forms.Button Setra;
        private System.Windows.Forms.Button Neoplan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button anasayfa;
    }
}