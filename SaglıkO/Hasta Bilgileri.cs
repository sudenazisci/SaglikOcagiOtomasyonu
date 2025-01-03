using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SaglıkO
{
    public partial class Hasta_Bilgileri : Form
    {
        private string connectionString = "Data Source=sudethinkpad\\MSSQLSERVER01;Initial Catalog=SaglıkO;Integrated Security=True;Trust Server Certificate=True";
        private PrintDocument printDocument = new PrintDocument();
        public Hasta_Bilgileri()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Hasta_Bilgileri_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Column1", "Poliklinik");
            dataGridView1.Columns.Add("Column2", "Sıra No");
            dataGridView1.Columns.Add("Column3", "İşlem");
            dataGridView1.Columns.Add("Column4", "Dr.Kodu");
            dataGridView1.Columns.Add("Column5", "Miktar");
            dataGridView1.Columns.Add("Column6", "Birim Fiyatı");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki verileri okuma
            string textBox1Value = textBox5.Text.Trim(); // Boşlukları temizleyerek alıyoruz
            string textBox2Value = textBox6.Text.Trim();

            // ComboBox'lardaki verileri okuma
            string comboBox1Value = string.IsNullOrWhiteSpace(comboBox2.Text) ? "" : comboBox2.Text.Trim();
            string comboBox2Value = string.IsNullOrWhiteSpace(comboBox5.Text) ? "" : comboBox5.Text.Trim();
            string comboBox3Value = string.IsNullOrWhiteSpace(comboBox3.Text) ? "" : comboBox3.Text.Trim();
            string comboBox4Value = string.IsNullOrWhiteSpace(comboBox4.Text) ? "" : comboBox4.Text.Trim();

            // Tüm alanların doldurulup doldurulmadığını kontrol etme
            if (!string.IsNullOrWhiteSpace(textBox1Value) &&
                !string.IsNullOrWhiteSpace(textBox2Value) &&
                !string.IsNullOrWhiteSpace(comboBox1Value) &&
                !string.IsNullOrWhiteSpace(comboBox2Value) &&
                !string.IsNullOrWhiteSpace(comboBox3Value) &&
                !string.IsNullOrWhiteSpace(comboBox4Value))
            {
                // DataGridView'e yeni satır ekleme
                dataGridView1.Rows.Add(textBox1Value, textBox2Value, comboBox1Value, comboBox2Value, comboBox3Value, comboBox4Value, "Eklenebilir Bilgi");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBox5.Clear();
            textBox6.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullanıcıdan onay al
                DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?",
                                                      "Onay",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Seçili satırı sil
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) // Yeni satır değilse sil
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            try
            {
                // Önizleme ekranını göster
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Önizleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // DataGridView'i yazdırma için çizdirme
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float yPosition = e.MarginBounds.Top;
            float xPosition = e.MarginBounds.Left;

            // Sütun başlıklarını yazdırma
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, font, brush, xPosition, yPosition);
                xPosition += 100; // Sütun genişliği
            }

            yPosition += 30; // Bir sonraki satıra geç

            // Satır verilerini yazdırma
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                xPosition = e.MarginBounds.Left;

                if (!row.IsNewRow) // Yeni satır hariç
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        e.Graphics.DrawString(row.Cells[i].Value?.ToString() ?? "", font, brush, xPosition, yPosition);
                        xPosition += 100; // Sütun genişliği
                    }

                    yPosition += 20; // Bir sonraki satıra geç
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            try
            {
                // Önizleme ekranını göster
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Önizleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu formu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hasta_Kayıt hastaKayitForm = new Hasta_Kayıt();


            hastaKayitForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dosya_Bul dosya_Bul = new Dosya_Bul();

            dosya_Bul.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Taburcu_İşlemleri taburcu_İşlemleri = new Taburcu_İşlemleri();
            taburcu_İşlemleri.Show();

        }

        private void Hasta_Bilgileri_Load_1(object sender, EventArgs e)
        {

        }
    }
}


