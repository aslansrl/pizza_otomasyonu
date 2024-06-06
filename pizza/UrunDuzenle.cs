using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pizza
{
        public partial class UrunDuzenle : Form
        {
            private string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";
        private DataGridView dgvDuzenle;
        private Label label1;
        private Button button1;
        private TextBox txtUrunAdi1;
        private TextBox txtUrunFiyati1;
        private ComboBox cmbUrunBoyut1;
        private ComboBox cmbUrunTuru1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private int selectedProductID = -1; // Başlangıçta seçilen ürün yok

            public UrunDuzenle()
            {
                InitializeComponent();
            }

            private void UrunDuzenle_Load(object sender, EventArgs e)
            {
                LoadProducts();
            }

            private void LoadProducts()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Ürünleri veritabanından al
                        string query = "SELECT * FROM urunler";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // DataGridView'e verileri yükle
                        dgvDuzenle.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }

            private void dgvDuzenle_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvDuzenle.Rows[e.RowIndex];
                    selectedProductID = Convert.ToInt32(row.Cells["urunID"].Value);

                    txtUrunAdi1.Text = row.Cells["urunAd"].Value.ToString();
                    txtUrunFiyati1.Text = row.Cells["urunFiyat"].Value.ToString();
                    cmbUrunBoyut1.SelectedItem = row.Cells["urunBoyut"].Value.ToString();
                    cmbUrunTuru1.SelectedItem = row.Cells["urunTur"].Value.ToString();
                }
            }

            private void btnGuncelle_Click(object sender, EventArgs e)
            {
                if (selectedProductID != -1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Seçilen ürünün bilgilerini güncelle
                            string query = "UPDATE urunler SET urunAd = @UrunAdi, urunFiyat = @UrunFiyati, urunBoyut = @UrunBoyutu, urunTur = @UrunTuru WHERE urunID = @UrunID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UrunID", selectedProductID);
                            command.Parameters.AddWithValue("@UrunAdi", txtUrunAdi1.Text);
                            command.Parameters.AddWithValue("@UrunFiyati", decimal.Parse(txtUrunFiyati1.Text));
                            command.Parameters.AddWithValue("@UrunBoyutu", int.Parse(cmbUrunBoyut1.Text));
                            command.Parameters.AddWithValue("@UrunTuru", cmbUrunTuru1.SelectedItem.ToString());

                            command.ExecuteNonQuery();
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                            LoadProducts(); // Yeniden yükle
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen düzenlemek istediğiniz ürünü seçin.");
                }
            }

        private void InitializeComponent()
        {
            this.dgvDuzenle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrunAdi1 = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati1 = new System.Windows.Forms.TextBox();
            this.cmbUrunBoyut1 = new System.Windows.Forms.ComboBox();
            this.cmbUrunTuru1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDuzenle
            // 
            this.dgvDuzenle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuzenle.Location = new System.Drawing.Point(12, 240);
            this.dgvDuzenle.Name = "dgvDuzenle";
            this.dgvDuzenle.Size = new System.Drawing.Size(590, 213);
            this.dgvDuzenle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Düzenleme Ekranı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ürün Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUrunAdi1
            // 
            this.txtUrunAdi1.Location = new System.Drawing.Point(155, 81);
            this.txtUrunAdi1.Name = "txtUrunAdi1";
            this.txtUrunAdi1.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi1.TabIndex = 3;
            // 
            // txtUrunFiyati1
            // 
            this.txtUrunFiyati1.Location = new System.Drawing.Point(155, 128);
            this.txtUrunFiyati1.Name = "txtUrunFiyati1";
            this.txtUrunFiyati1.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyati1.TabIndex = 4;
            // 
            // cmbUrunBoyut1
            // 
            this.cmbUrunBoyut1.FormattingEnabled = true;
            this.cmbUrunBoyut1.Location = new System.Drawing.Point(393, 80);
            this.cmbUrunBoyut1.Name = "cmbUrunBoyut1";
            this.cmbUrunBoyut1.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunBoyut1.TabIndex = 5;
            // 
            // cmbUrunTuru1
            // 
            this.cmbUrunTuru1.FormattingEnabled = true;
            this.cmbUrunTuru1.Location = new System.Drawing.Point(393, 128);
            this.cmbUrunTuru1.Name = "cmbUrunTuru1";
            this.cmbUrunTuru1.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunTuru1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Boyut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Tür:";
            // 
            // UrunDuzenle
            // 
            this.ClientSize = new System.Drawing.Size(614, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUrunTuru1);
            this.Controls.Add(this.cmbUrunBoyut1);
            this.Controls.Add(this.txtUrunFiyati1);
            this.Controls.Add(this.txtUrunAdi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDuzenle);
            this.Name = "UrunDuzenle";
            this.Load += new System.EventHandler(this.UrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
    }


