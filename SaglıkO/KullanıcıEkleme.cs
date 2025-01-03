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
    public partial class KullanıcıEkleme : Form
    {
        public KullanıcıEkleme()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu formu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kaydedilecek dosya yolu
                string filePath = "C:\\Users\\iscit\\OneDrive\\Masaüstü\\KullanıcıBilgileri.txt";

                // TextBox'ların içeriğini toplama
                string bilgiler = $"Kullanıcı Kodu: {textBox1.Text}\n" +
                                  $"Ad: {textBox8.Text}\n" +
                                  $"Soyad: {textBox9.Text}\n" +
                                  $"T.C. Numara: {textBox2.Text}\n" +
                                  $"Doğum Yeri: {textBox3.Text}\n" +
                                  $"Baba Adı: {textBox4.Text}\n" +
                                  $"Anne Adı: {textBox4.Text}\n" +
                                  $"Telefon: {textBox5.Text}\n" +
                                  $"Unvan: {comboBox1.Text}\n" +
                                  $"Adres: {richTextBox1.Text}\n" +
                                  $"Kullanıcı Adı: {textBox7.Text}\n" +
                                  $"Cinsiyet: {comboBox3.Text}\n" +
                                  $"Kan Grubu: {comboBox4.Text}\n" +
                                  $"İşe Başlama Tarihi: {dateTimePicker1.Value.ToShortDateString()}\n" +
                                  $"Doğum Tarihi: {dateTimePicker2.Value.ToShortDateString()}\n" +
                                  $"Şifre: {textBox11.Text}\n";

                // Dosyaya yazma işlemi
                File.WriteAllText(filePath, bilgiler);

                // Kullanıcıya başarı mesajı göster
                MessageBox.Show("Bilgiler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Bilgiler kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

