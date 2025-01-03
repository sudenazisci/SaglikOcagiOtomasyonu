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
    public partial class KullanıcıTanıtmacs : Form
    {
        public KullanıcıTanıtmacs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıEkleme kullanıcıEkleme=new KullanıcıEkleme();
            kullanıcıEkleme.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
