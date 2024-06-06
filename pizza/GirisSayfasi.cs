using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class GirisSayfasi : Form
    {
        private Label label1;
        private Button btnKayıtOl;
        private Button btnGrsYap;
        private Button btnAdmnGrs;
        private Button btnCksYap;

        public GirisSayfasi()
        {
            InitializeComponent();  
        }
       
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            // Kayıt Ol butonuna tıklandığında KayitFormu adındaki forma yönlendirme
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnGrsYap_Click(object sender, EventArgs e)
        {
            // Giriş Yap butonuna tıklandığında GirisFormu adındaki forma yönlendirme
            GirişEkrani frm2 = new GirişEkrani();
            frm2.Show();
            this.Hide();
        }

        private void btnAdmnGrs_Click(object sender, EventArgs e)
        {
            // Admin Ekranı butonuna tıklandığında AdminFormu adındaki forma yönlendirme
            AdminEkrani frm3 = new AdminEkrani();
            frm3.Show();
            this.Hide();
        }

        private void btnCksYap_Click(object sender, EventArgs e)
        {
            // Çıkış Yap butonuna tıklandığında uygulamayı sonlandırma
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.btnGrsYap = new System.Windows.Forms.Button();
            this.btnAdmnGrs = new System.Windows.Forms.Button();
            this.btnCksYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ SAYFASI";
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(12, 116);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayıtOl.TabIndex = 1;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // btnGrsYap
            // 
            this.btnGrsYap.Location = new System.Drawing.Point(12, 158);
            this.btnGrsYap.Name = "btnGrsYap";
            this.btnGrsYap.Size = new System.Drawing.Size(75, 23);
            this.btnGrsYap.TabIndex = 2;
            this.btnGrsYap.Text = "Giriş Yap";
            this.btnGrsYap.UseVisualStyleBackColor = true;
            this.btnGrsYap.Click += new System.EventHandler(this.btnGrsYap_Click);
            // 
            // btnAdmnGrs
            // 
            this.btnAdmnGrs.Location = new System.Drawing.Point(12, 199);
            this.btnAdmnGrs.Name = "btnAdmnGrs";
            this.btnAdmnGrs.Size = new System.Drawing.Size(75, 23);
            this.btnAdmnGrs.TabIndex = 3;
            this.btnAdmnGrs.Text = "Admin Giriş";
            this.btnAdmnGrs.UseVisualStyleBackColor = true;
            this.btnAdmnGrs.Click += new System.EventHandler(this.btnAdmnGrs_Click);
            // 
            // btnCksYap
            // 
            this.btnCksYap.Location = new System.Drawing.Point(12, 238);
            this.btnCksYap.Name = "btnCksYap";
            this.btnCksYap.Size = new System.Drawing.Size(75, 23);
            this.btnCksYap.TabIndex = 4;
            this.btnCksYap.Text = "Çıkış Yap";
            this.btnCksYap.UseVisualStyleBackColor = true;
            this.btnCksYap.Click += new System.EventHandler(this.btnCksYap_Click);
            // 
            // GirisSayfasi
            // 
            this.ClientSize = new System.Drawing.Size(312, 435);
            this.Controls.Add(this.btnCksYap);
            this.Controls.Add(this.btnAdmnGrs);
            this.Controls.Add(this.btnGrsYap);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.label1);
            this.Name = "GirisSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
    }
}
