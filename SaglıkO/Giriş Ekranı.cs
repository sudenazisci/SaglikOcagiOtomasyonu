using System;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Data.SqlClient;




namespace SaglıkO
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            con = new SqlConnection("Data Source=SUDETHINKPAD;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");

            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Kullanıcı_Bilgi where kullanici_adi='" + textBox1.Text + "'And sifre= '" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



