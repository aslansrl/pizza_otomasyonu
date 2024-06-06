using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace pizza
{
    
        public partial class UrunSil : Form
    {
        private Label label1;
        private DataGridView dgvSil;
        private Button btnSil;
        private string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";

            public UrunSil()
            {
                InitializeComponent();
            }

            private void UrunSil_Load(object sender, EventArgs e)
            {
                // Form yüklendiğinde ürünleri göster
                ShowProducts();
            }

            private void ShowProducts()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Ürünleri veritabanından al
                        string query = "SELECT * FROM Urunler";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // DataGridView'e verileri yükle
                        dgvSil.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }

            private void btnSil_Click(object sender, EventArgs e)
            {
                // Kullanıcı seçimi kontrol et
                if (dgvSil.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgvSil.SelectedCells[0].RowIndex;
                    int urunID = Convert.ToInt32(dgvSil.Rows[selectedRowIndex].Cells["urunID"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Seçili ürünü sil
                            string query = "DELETE FROM Urunler WHERE urunID = @UrunID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UrunID", urunID);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Ürün başarıyla silindi.");
                            ShowProducts(); // Güncel ürün listesini göster
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.");
                }
            }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSil = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Silme Ekranı";
            // 
            // dgvSil
            // 
            this.dgvSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSil.Location = new System.Drawing.Point(12, 111);
            this.dgvSil.Name = "dgvSil";
            this.dgvSil.Size = new System.Drawing.Size(630, 307);
            this.dgvSil.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 82);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Ürün Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // UrunSil
            // 
            this.ClientSize = new System.Drawing.Size(654, 430);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvSil);
            this.Controls.Add(this.label1);
            this.Name = "UrunSil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
    }


