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
    public partial class Hasta_Kayıt : Form
    {
        public Hasta_Kayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaNo = textBox1.Text.Trim();
            string ad = textBox2.Text.Trim();
            string soyad = textBox3.Text.Trim();
            string tc = textBox4.Text.Trim();
            string dogumYeri = textBox5.Text.Trim();
            DateTime dogumTarihi = dateTimePicker1.Value;
            string babaAdi = textBox6.Text.Trim();
            string anneAdi = textBox7.Text.Trim();
            string adres = richTextBox1.Text.Trim();
            string telefon = textBox8.Text.Trim();
            string yakinTelefon = textBox9.Text.Trim();
            string kurumSicilNo = textBox10.Text.Trim();
            string kurumAdi = textBox11.Text.Trim();

            // ComboBox'lardan verileri al
            string cinsiyet = comboBox1.SelectedItem?.ToString() ?? "";
            string kanGrubu = comboBox2.SelectedItem?.ToString() ?? "";
            string medeniHali = comboBox3.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(dosyaNo) &&
                !string.IsNullOrWhiteSpace(ad) &&
                !string.IsNullOrWhiteSpace(soyad) &&
                !string.IsNullOrWhiteSpace(tc))
            {
                try
                {
                    // SQL bağlantısı için connection string
                    string connectionString = "Data Source=sudethinkpad\\MSSQLSERVER01;Initial Catalog=SaglıkO;Integrated Security=True;Trust Server Certificate=True;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL INSERT komutu
                        string query = @"INSERT INTO HastaBilgileri 
                                         (DosyaNo, Ad, Soyad, Tc, DogumYeri, DogumTarihi, BabaAdi, AnneAdi, Adres, Telefon, YakinTelefon, 
                                          KurumSicilNo, KurumAdi, Cinsiyet, KanGrubu, MedeniHali) 
                                         VALUES 
                                         (@DosyaNo, @Ad, @Soyad, @Tc, @DogumYeri, @DogumTarihi, @BabaAdi, @AnneAdi, @Adres, @Telefon, 
                                          @YakinTelefon, @KurumSicilNo, @KurumAdi, @Cinsiyet, @KanGrubu, @MedeniHali)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@DosyaNo", dosyaNo);
                            command.Parameters.AddWithValue("@Ad", ad);
                            command.Parameters.AddWithValue("@Soyad", soyad);
                            command.Parameters.AddWithValue("@Tc", tc);
                            command.Parameters.AddWithValue("@DogumYeri", dogumYeri);
                            command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                            command.Parameters.AddWithValue("@BabaAdi", babaAdi);
                            command.Parameters.AddWithValue("@AnneAdi", anneAdi);
                            command.Parameters.AddWithValue("@Adres", adres);
                            command.Parameters.AddWithValue("@Telefon", telefon);
                            command.Parameters.AddWithValue("@YakinTelefon", yakinTelefon);
                            command.Parameters.AddWithValue("@KurumSicilNo", kurumSicilNo);
                            command.Parameters.AddWithValue("@KurumAdi", kurumAdi);
                            command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                            command.Parameters.AddWithValue("@KanGrubu", kanGrubu);
                            command.Parameters.AddWithValue("@MedeniHali", medeniHali);

                            // Komutu çalıştır
                            command.ExecuteNonQuery();
                        }
                    }

                    // Başarılı mesajı
                    MessageBox.Show("Veriler başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    richTextBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Eksik alan uyarısı
                MessageBox.Show("Lütfen gerekli alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu formu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

