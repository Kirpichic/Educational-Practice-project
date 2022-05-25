using MySqlConnector;
using Rogozin_yp02.Администратор;
using Rogozin_yp02.МедРегистратор;
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
    public partial class РегОсн : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public РегОсн()
        {
            InitializeComponent();
            conn.Open();
        }

        private void РегОсн_Load(object sender, EventArgs e)
        {
            /*Загрузка таблицы Клиенты*/
            string query = "SELECT * FROM клиенты";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader.GetInt64(0).ToString();
                data[data.Count - 1][1] = reader.GetString(1);
                data[data.Count - 1][2] = reader.GetString(2);
                data[data.Count - 1][3] = reader.GetDateTime(3).ToShortDateString();
                data[data.Count - 1][4] = reader.GetString(4);
                data[data.Count - 1][5] = reader.GetInt64(5).ToString();
                data[data.Count - 1][6] = reader.GetString(6);
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            /*Загрузка таблицы Клиенты*/

            /*Загрузка таблицы Услуги*/
            string query2 = "SELECT * FROM услуги";
            MySqlCommand command2 = new MySqlCommand(query2, conn);
            MySqlDataReader reader2 = command2.ExecuteReader();

            List<string[]> data2 = new List<string[]>();
            while (reader2.Read())
            {
                data2.Add(new string[4]);

                data2[data2.Count - 1][0] = reader2.GetInt64(0).ToString();
                data2[data2.Count - 1][1] = reader2.GetString(1);
                data2[data2.Count - 1][2] = reader2.GetDecimal(2).ToString();
                data2[data2.Count - 1][3] = reader2.GetInt64(3).ToString();

            }

            reader2.Close();

            foreach (string[] z in data2)
                dataGridView3.Rows.Add(z);
            /*Загрузка таблицы Услуги*/
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enter form = new Enter();
            form.Show();
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            РегДоб n = new РегДоб();
            n.Show();
            this.Close();
        }

        private void просмотрДоговоровToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            РегПросмотрДоговоров n1 = new РегПросмотрДоговоров();
            n1.Show();
        }

        private void созданиеДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Договор n2 = new Договор();
            n2.Show();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Enter form = new Enter();
            form.Show();
            this.Close();
        }

        private void выходToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            РегУдал f8 = new РегУдал();
            f8.Show();
        }
    }
}
