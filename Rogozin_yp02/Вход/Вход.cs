using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rogozin_yp02
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Login = new string[] { "admin", "head", "regis" };
            string[] Password = new string[] { "0000", "1234", "1111" };

            if (textBox1.Text == Login[0] && textBox2.Text == Password[0])
            {
                АдминОсн frm = new АдминОсн();
                frm.Show();
                Hide();
            }
            else if (textBox1.Text == Login[1] && textBox2.Text == Password[1])
            {
                ЗавОсн fr = new ЗавОсн();
                fr.Show();
                Hide();
            }
            else if (textBox1.Text == Login[2] && textBox2.Text == Password[2])
            {
                РегОсн f = new РегОсн();
                f.Show();
                Hide();
            }
            else  if (textBox1.Text != Login[0] || textBox1.Text != Login[1] || textBox1.Text != Login[2])
            {
                MessageBox.Show("Не правильный логин или пароль.", "Внимание!" );
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
