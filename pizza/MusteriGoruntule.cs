using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pizza
{
  
        public partial class MusteriGoruntule : Form
    {
        private Label label1;
        private DataGridView dataGridView1;

        // SQL bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";

            public MusteriGoruntule()
            {
                InitializeComponent();
            }

            private void MusteriGoruntule_Load(object sender, EventArgs e)
            {
                // Verileri DataGridView'e yükle
                VerileriGetir();
            }

            private void VerileriGetir()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL sorgusu
                    string query = "SELECT KullaniciID, Ad, Soyad, Email, Sifre, Adres FROM Kullanici";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Veri tablosu
                        DataTable dataTable = new DataTable();

                        // Bağlantıyı aç
                        connection.Open();

                        // Verileri oku
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Verileri data table'a yükle
                            dataTable.Load(reader);

                            // DataGridView'e verileri yükle
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı.");
                        }
                    }
                }
            }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Görüntüle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 240);
            this.dataGridView1.TabIndex = 1;
            // 
            // MusteriGoruntule
            // 
            this.ClientSize = new System.Drawing.Size(563, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MusteriGoruntule";
            this.Load += new System.EventHandler(this.MusteriGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
    }


