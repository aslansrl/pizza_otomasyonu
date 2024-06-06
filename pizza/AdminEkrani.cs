using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class AdminEkrani : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtadminad;
        private TextBox txtAdminSifre;
        private Button button1;

        public AdminEkrani()
        {
            InitializeComponent();
        }


        private void btnAdmGrs_Click(object sender, EventArgs e)
        {
            string adminad = txtadminad.Text;
            string adminsifre = txtAdminSifre.Text;

            if (string.IsNullOrEmpty(adminad) || string.IsNullOrEmpty(adminsifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }

            if (KullaniciGirisKontrol(adminad, adminsifre))
            {
                MessageBox.Show("Giriş başarılı.");
                 
                this.Hide();
                // KontrolPanel formunu oluştur
                KontrolPanel kontrolPanelForm = new KontrolPanel();

                // KontrolPanel formunu göster
                kontrolPanelForm.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private bool KullaniciGirisKontrol(string adminad, string adminsifre)
        {
            bool kontrol = false;

            string connectionString = "Data Source=DESKTOP-2A3HEO8;Initial Catalog=Ödev;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM admin WHERE adminad = @AdminAd AND adminşifre = @AdminSifre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminAd", adminad);
                    command.Parameters.AddWithValue("@AdminSifre", adminsifre);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        kontrol = true;
                    }
                }
            }

            return kontrol;
        }
        

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadminad = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KULLANICI AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE:";
            // 
            // txtadminad
            // 
            this.txtadminad.Location = new System.Drawing.Point(126, 125);
            this.txtadminad.Name = "txtadminad";
            this.txtadminad.Size = new System.Drawing.Size(100, 20);
            this.txtadminad.TabIndex = 3;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(126, 163);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(100, 20);
            this.txtAdminSifre.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdmGrs_Click);
            // 
            // AdminEkrani
            // 
            this.ClientSize = new System.Drawing.Size(568, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtadminad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
}
