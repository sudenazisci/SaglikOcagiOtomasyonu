using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaglıkO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


                // Seçim yapıldıktan sonra başka bir formu aç
                if (comboBox1.SelectedIndex != -1) // Eğer geçerli bir seçim yapıldıysa
                {
                    // Yeni formu oluştur ve göster
                    Form4 yeniForm = new Form4();
                    yeniForm.Show();

                    // İsterseniz mevcut formu gizleyebilirsiniz
                    this.Hide();
                }
            }
        }
    }


