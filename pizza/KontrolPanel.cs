using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pizza
{
 
        public partial class KontrolPanel : Form
    {
        private Label label1;
        private Button BtnMusterileriGoruntule;
        private Button btnUrunEkle;
        private Button BtnUrunSil;
        private Button BtnUrunDuzenle;
        private Button BtnAdminEkle;
        private Button btnAnaSyfDön;

        public KontrolPanel()
            {
                InitializeComponent();
            }

            private void BtnMusterileriGoruntule_Click(object sender, EventArgs e)
            {
                MusteriGoruntule musteriForm = new MusteriGoruntule();
                musteriForm.Show();

            }

            private void btnUrunEkle_Click(object sender, EventArgs e)
            {
                UrunEkle urunEkleForm = new UrunEkle();
                urunEkleForm.Show();
            }

            private void BtnUrunSil_Click(object sender, EventArgs e)
            {
                UrunSil urunSilForm = new UrunSil();
                urunSilForm.Show();
            }

            private void BtnUrunDuzenle_Click(object sender, EventArgs e)
            {
                UrunDuzenle urunDuzenleForm = new UrunDuzenle();
                urunDuzenleForm.Show();
            }

            private void BtnAdminEkle_Click(object sender, EventArgs e)
            {
                AdminEkle adminEkleForm = new AdminEkle();
                adminEkleForm.Show();
            }

            private void btnAnaSyfDön_Click(object sender, EventArgs e)
            {
                GirisSayfasi girisSayfasiForm = new GirisSayfasi();
                girisSayfasiForm.Show();
                this.Hide(); 
            }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMusterileriGoruntule = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunDuzenle = new System.Windows.Forms.Button();
            this.BtnAdminEkle = new System.Windows.Forms.Button();
            this.btnAnaSyfDön = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontrol Paneli";
            // 
            // BtnMusterileriGoruntule
            // 
            this.BtnMusterileriGoruntule.Location = new System.Drawing.Point(88, 184);
            this.BtnMusterileriGoruntule.Name = "BtnMusterileriGoruntule";
            this.BtnMusterileriGoruntule.Size = new System.Drawing.Size(114, 60);
            this.BtnMusterileriGoruntule.TabIndex = 1;
            this.BtnMusterileriGoruntule.Text = "Müşterileri Görüntüle";
            this.BtnMusterileriGoruntule.UseVisualStyleBackColor = true;
            this.BtnMusterileriGoruntule.Click += new System.EventHandler(this.BtnMusterileriGoruntule_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(88, 270);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(114, 60);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(88, 367);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(114, 60);
            this.BtnUrunSil.TabIndex = 3;
            this.BtnUrunSil.Text = "Ürün Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // BtnUrunDuzenle
            // 
            this.BtnUrunDuzenle.Location = new System.Drawing.Point(356, 184);
            this.BtnUrunDuzenle.Name = "BtnUrunDuzenle";
            this.BtnUrunDuzenle.Size = new System.Drawing.Size(114, 60);
            this.BtnUrunDuzenle.TabIndex = 4;
            this.BtnUrunDuzenle.Text = "Ürün Düzenle";
            this.BtnUrunDuzenle.UseVisualStyleBackColor = true;
            this.BtnUrunDuzenle.Click += new System.EventHandler(this.BtnUrunDuzenle_Click);
            // 
            // BtnAdminEkle
            // 
            this.BtnAdminEkle.Location = new System.Drawing.Point(356, 270);
            this.BtnAdminEkle.Name = "BtnAdminEkle";
            this.BtnAdminEkle.Size = new System.Drawing.Size(114, 60);
            this.BtnAdminEkle.TabIndex = 5;
            this.BtnAdminEkle.Text = "Admin Ekle";
            this.BtnAdminEkle.UseVisualStyleBackColor = true;
            this.BtnAdminEkle.Click += new System.EventHandler(this.BtnAdminEkle_Click);
            // 
            // btnAnaSyfDön
            // 
            this.btnAnaSyfDön.Location = new System.Drawing.Point(356, 367);
            this.btnAnaSyfDön.Name = "btnAnaSyfDön";
            this.btnAnaSyfDön.Size = new System.Drawing.Size(114, 60);
            this.btnAnaSyfDön.TabIndex = 6;
            this.btnAnaSyfDön.Text = "Anasayfaya Dön";
            this.btnAnaSyfDön.UseVisualStyleBackColor = true;
            this.btnAnaSyfDön.Click += new System.EventHandler(this.btnAnaSyfDön_Click);
            // 
            // KontrolPanel
            // 
            this.ClientSize = new System.Drawing.Size(571, 615);
            this.Controls.Add(this.btnAnaSyfDön);
            this.Controls.Add(this.BtnAdminEkle);
            this.Controls.Add(this.BtnUrunDuzenle);
            this.Controls.Add(this.BtnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.BtnMusterileriGoruntule);
            this.Controls.Add(this.label1);
            this.Name = "KontrolPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
    }


