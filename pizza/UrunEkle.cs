using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pizza
{
 
        public partial class UrunEkle : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUrunAdi;
        private TextBox txtUrunFiyati;
        private ComboBox cmbUrunBoyut;
        private Label label5;
        private Button btnUrunEkle1;
        private ComboBox cmbUrunTuru;

        // Veritabanı bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";

            public UrunEkle()
            {
                InitializeComponent();
            }

            private void btnUrunEkle1_Click(object sender, EventArgs e)
            {
                string urunAdi = txtUrunAdi.Text;
                decimal urunFiyati = decimal.Parse(txtUrunFiyati.Text);
                string urunBoyut = cmbUrunBoyut.SelectedItem.ToString();
                string urunTuru = cmbUrunTuru.SelectedItem.ToString(); // Kullanıcının seçtiği ürün türü

                // Veritabanı bağlantısı oluşturma
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL sorgusu
                        string query = "INSERT INTO urunler (urunAd, urunFiyat, urunBoyut, urunTur) VALUES (@UrunAd, @UrunFiyat, @UrunBoyut, @UrunTur)";

                        // Parametrelerle SQL komutunu oluşturma
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UrunAd", urunAdi);
                        command.Parameters.AddWithValue("@UrunFiyat", urunFiyati);
                        command.Parameters.AddWithValue("@UrunBoyut", urunBoyut);
                        command.Parameters.AddWithValue("@UrunTur", urunTuru);

                        // Komutu çalıştırma
                        command.ExecuteNonQuery();

                        MessageBox.Show("Ürün başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.cmbUrunBoyut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUrunEkle1 = new System.Windows.Forms.Button();
            this.cmbUrunTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ekleme Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Boyutu";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(108, 71);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(142, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(108, 101);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(142, 20);
            this.txtUrunFiyati.TabIndex = 5;
            // 
            // cmbUrunBoyut
            // 
            this.cmbUrunBoyut.FormattingEnabled = true;
            this.cmbUrunBoyut.Location = new System.Drawing.Point(108, 133);
            this.cmbUrunBoyut.Name = "cmbUrunBoyut";
            this.cmbUrunBoyut.Size = new System.Drawing.Size(142, 21);
            this.cmbUrunBoyut.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Türü:";
            // 
            // btnUrunEkle1
            // 
            this.btnUrunEkle1.Location = new System.Drawing.Point(147, 231);
            this.btnUrunEkle1.Name = "btnUrunEkle1";
            this.btnUrunEkle1.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle1.TabIndex = 9;
            this.btnUrunEkle1.Text = "Ürün Ekle";
            this.btnUrunEkle1.UseVisualStyleBackColor = true;
            this.btnUrunEkle1.Click += new System.EventHandler(this.btnUrunEkle1_Click);
            // 
            // cmbUrunTuru
            // 
            this.cmbUrunTuru.FormattingEnabled = true;
            this.cmbUrunTuru.Location = new System.Drawing.Point(108, 165);
            this.cmbUrunTuru.Name = "cmbUrunTuru";
            this.cmbUrunTuru.Size = new System.Drawing.Size(142, 21);
            this.cmbUrunTuru.TabIndex = 10;
            // 
            // UrunEkle
            // 
            this.ClientSize = new System.Drawing.Size(510, 393);
            this.Controls.Add(this.cmbUrunTuru);
            this.Controls.Add(this.btnUrunEkle1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUrunBoyut);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
    }


