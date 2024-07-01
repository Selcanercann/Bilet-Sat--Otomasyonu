namespace projeodevigorselprogramlama
{
    partial class Personel_Maaş
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tcsi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meslegi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.goster = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adı,
            this.Soyadı,
            this.Tcsi,
            this.meslegi,
            this.maasi});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 305);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(673, 290);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Adı
            // 
            this.Adı.Text = "Tc";
            this.Adı.Width = 112;
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "Ad";
            this.Soyadı.Width = 127;
            // 
            // Tcsi
            // 
            this.Tcsi.Text = "Soyad";
            this.Tcsi.Width = 151;
            // 
            // meslegi
            // 
            this.meslegi.Text = "Meslek";
            this.meslegi.Width = 149;
            // 
            // maasi
            // 
            this.maasi.Text = "Maaş";
            this.maasi.Width = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Adı";
            // 
            // txtsoyad
            // 
            this.txtsoyad.BackColor = System.Drawing.Color.White;
            this.txtsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(89, 54);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(173, 26);
            this.txtsoyad.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Soyadı";
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.White;
            this.txtad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(89, 16);
            this.txtad.Margin = new System.Windows.Forms.Padding(2);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(173, 26);
            this.txtad.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Telefon No";
            // 
            // txtmeslek
            // 
            this.txtmeslek.BackColor = System.Drawing.Color.White;
            this.txtmeslek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmeslek.Location = new System.Drawing.Point(332, 16);
            this.txtmeslek.Margin = new System.Windows.Forms.Padding(2);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(170, 26);
            this.txtmeslek.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(275, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 77;
            this.label10.Text = "Meslek";
            // 
            // txtmaas
            // 
            this.txtmaas.BackColor = System.Drawing.Color.White;
            this.txtmaas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmaas.Location = new System.Drawing.Point(332, 54);
            this.txtmaas.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(170, 26);
            this.txtmaas.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(275, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Maaş";
            // 
            // txttc
            // 
            this.txttc.BackColor = System.Drawing.Color.White;
            this.txttc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(89, 88);
            this.txttc.Margin = new System.Windows.Forms.Padding(2);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(173, 26);
            this.txttc.TabIndex = 81;
            // 
            // txtara
            // 
            this.txtara.BackColor = System.Drawing.Color.White;
            this.txtara.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(336, 89);
            this.txtara.Margin = new System.Windows.Forms.Padding(2);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(164, 26);
            this.txtara.TabIndex = 87;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(193, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 20);
            this.label20.TabIndex = 99;
            this.label20.Text = "Veri Temizle";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(488, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 20);
            this.label19.TabIndex = 98;
            this.label19.Text = "Veri Güncelle";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(346, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 97;
            this.label18.Text = "Veri Sil";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(535, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 96;
            this.label17.Text = "Ana Sayfaya Dön";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(50, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 95;
            this.label15.Text = "Verileri Göster";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(267, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 100;
            this.label16.Text = "Veri Ara";
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.anasayfa.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__17_;
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfa.Location = new System.Drawing.Point(548, 31);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(100, 56);
            this.anasayfa.TabIndex = 88;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ara.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__16_;
            this.ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ara.Location = new System.Drawing.Point(505, 89);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(48, 26);
            this.ara.TabIndex = 86;
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Aqua;
            this.sil.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__14_;
            this.sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sil.Location = new System.Drawing.Point(350, 175);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(100, 100);
            this.sil.TabIndex = 85;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Aqua;
            this.temizle.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__13_;
            this.temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.temizle.Location = new System.Drawing.Point(197, 175);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(100, 100);
            this.temizle.TabIndex = 84;
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // goster
            // 
            this.goster.BackColor = System.Drawing.Color.Aqua;
            this.goster.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__12_;
            this.goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goster.Location = new System.Drawing.Point(54, 175);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(100, 100);
            this.goster.TabIndex = 83;
            this.goster.UseVisualStyleBackColor = false;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Aqua;
            this.guncelle.BackgroundImage = global::projeodevigorselprogramlama.Properties.Resources.pngwing_com__15_;
            this.guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guncelle.Location = new System.Drawing.Point(492, 175);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(100, 100);
            this.guncelle.TabIndex = 82;
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // Personel_Maaş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(688, 598);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmeslek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.listView1);
            this.Name = "Personel_Maaş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş";
           this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ColumnHeader Tcsi;
        private System.Windows.Forms.ColumnHeader meslegi;
        private System.Windows.Forms.ColumnHeader maasi;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ara;
        public System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}