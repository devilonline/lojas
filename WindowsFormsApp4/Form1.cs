using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Enter(object sender, KeyPressEventArgs e)
        //{
        //    MessageBox.Show("cesar");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=DESKTOP-J9KEMU1;Initial Catalog=Test;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            //MessageBox.Show("DB Connected");
            String sqlSelecQuery = "SELECT * FROM lojass WHERE loja = " + int.Parse(textBox1.Text);
            SqlCommand cmd = new SqlCommand(sqlSelecQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label2.Text = (dr["nome"].ToString());
            }
        }

        //private void Enter(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        MessageBox.Show("cesar");
        //    }
            
        //}
    }
}
