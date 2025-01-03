using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglıkO
{
    public partial class Dosya_Bul : Form
    {
        private string connectionString = "Data Source=sudethinkpad\\MSSQLSERVER01;Initial Catalog=SaglıkO;Integrated Security=True;Trust Server Certificate=True";
        public Dosya_Bul()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCriteria = comboBox1.SelectedItem?.ToString();  // ComboBox'tan seçilen değeri alıyoruz
            string searchValue = textBox1.Text;

            // Eğer ComboBox'da herhangi bir değer seçilmediyse, kullanıcıyı uyarın
            if (string.IsNullOrEmpty(selectedCriteria))
            {
                MessageBox.Show("Lütfen geçerli bir arama kriteri seçin.");
                return;
            }

            string query = string.Empty;

            // Arama kriterine göre sorgu oluşturuluyor
            if (selectedCriteria == "Ad")
                query = "SELECT * FROM HastaBilgileri WHERE Ad LIKE @value";
            else if (selectedCriteria == "Soyad")
                query = "SELECT * FROM HastaBilgileri WHERE Soyad LIKE @value";
            else if (selectedCriteria == "Tc")
                query = "SELECT * FROM HastaBilgileri WHERE Tc LIKE @value";
            else if (selectedCriteria == "DosyaNo")
                query = "SELECT * FROM HastaBilgileri WHERE DosyaNo LIKE @value";

            // Eğer query hala boşsa, bir hata mesajı verin
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Geçersiz arama kriteri seçildi.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);  // Sorgu burada doğru şekilde ayarlanıyor
                    command.Parameters.AddWithValue("@value", "%" + searchValue + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Arama sonuçlarını DataGridView'da gösterme
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
    