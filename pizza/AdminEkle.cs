using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pizza
{
   
        public partial class AdminEkle : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdminAd;
        private TextBox textBoxAdminSifre;
        private Button btnAdmnEkle;

        // SQL Server bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";

            public AdminEkle()
            {
                InitializeComponent();
            }

            private void AdminEkle_Click(object sender, EventArgs e)
            {
                string adminAd = textBoxAdminAd.Text;
                string adminSifre = textBoxAdminSifre.Text;

                // SQL sorgusu
                string query = "INSERT INTO admin (adminad, adminşifre) VALUES (@adminAd, @adminSifre)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametrelerin eklenmesi
                        command.Parameters.AddWithValue("@adminAd", adminAd);
                        command.Parameters.AddWithValue("@adminSifre", adminSifre);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin başarıyla kaydedildi.");
                                // Başarılı kayıt durumunda temizleme veya diğer işlemler eklenebilir.
                            }
                            else
                            {
                                MessageBox.Show("Admin kaydedilirken bir hata oluştu.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdminAd = new System.Windows.Forms.TextBox();
            this.textBoxAdminSifre = new System.Windows.Forms.TextBox();
            this.btnAdmnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Ekleme Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Şifre:";
            // 
            // textBoxAdminAd
            // 
            this.textBoxAdminAd.Location = new System.Drawing.Point(204, 128);
            this.textBoxAdminAd.Name = "textBoxAdminAd";
            this.textBoxAdminAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdminAd.TabIndex = 3;
            // 
            // textBoxAdminSifre
            // 
            this.textBoxAdminSifre.Location = new System.Drawing.Point(204, 185);
            this.textBoxAdminSifre.Name = "textBoxAdminSifre";
            this.textBoxAdminSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdminSifre.TabIndex = 4;
            // 
            // btnAdmnEkle
            // 
            this.btnAdmnEkle.Location = new System.Drawing.Point(186, 304);
            this.btnAdmnEkle.Name = "btnAdmnEkle";
            this.btnAdmnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAdmnEkle.TabIndex = 5;
            this.btnAdmnEkle.Text = "Admin Ekle";
            this.btnAdmnEkle.UseVisualStyleBackColor = true;
            // 
            // AdminEkle
            // 
            this.ClientSize = new System.Drawing.Size(459, 378);
            this.Controls.Add(this.btnAdmnEkle);
            this.Controls.Add(this.textBoxAdminSifre);
            this.Controls.Add(this.textBoxAdminAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
    }


