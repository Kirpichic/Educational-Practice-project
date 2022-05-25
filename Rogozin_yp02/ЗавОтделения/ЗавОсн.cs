using MySqlConnector;
using Rogozin_yp02.ЗавОтделения;
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
    public partial class ЗавОсн : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);
        public ЗавОсн()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ЗавОсн_Load(object sender, EventArgs e)
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

            /*Загрузка таблицы Сотрудники*/
            string query1 = "SELECT * FROM сотрудники";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = command1.ExecuteReader();

            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[6]);

                data1[data1.Count - 1][0] = reader1.GetInt64(0).ToString();
                data1[data1.Count - 1][1] = reader1.GetString(1);
                data1[data1.Count - 1][2] = reader1.GetString(2);
                data1[data1.Count - 1][3] = reader1.GetDateTime(3).ToShortDateString();
                data1[data1.Count - 1][4] = reader1.GetString(4);
                data1[data1.Count - 1][5] = reader1.GetDateTime(5).ToShortDateString();

            }

            reader1.Close();

            foreach (string[] f in data1)
                dataGridView2.Rows.Add(f);
            /*Загрузка таблицы Сотрудники*/

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

            /*Загрузка таблицы Вакцины*/
            string query3 = "SELECT * FROM вакцины";
            MySqlCommand command3 = new MySqlCommand(query3, conn);
            MySqlDataReader reader3 = command3.ExecuteReader();

            List<string[]> data3 = new List<string[]>();
            while (reader3.Read())
            {
                data3.Add(new string[11]);

                data3[data3.Count - 1][0] = reader3.GetString(0);
                data3[data3.Count - 1][1] = reader3.GetString(1);
                data3[data3.Count - 1][2] = reader3.GetString(2);
                data3[data3.Count - 1][3] = reader3.GetString(3);
                data3[data3.Count - 1][4] = reader3.GetString(4);
                data3[data3.Count - 1][5] = reader3.GetString(5);
                data3[data3.Count - 1][6] = reader3.GetString(6);
                data3[data3.Count - 1][7] = reader3.GetString(7);
                data3[data3.Count - 1][8] = reader3.GetString(8);
                data3[data3.Count - 1][9] = reader3.GetString(9);
                data3[data3.Count - 1][10] = reader3.GetString(10);
            }

            reader3.Close();

            foreach (string[] x in data3)
                dataGridView4.Rows.Add(x);
            /*Загрузка таблицы Вакцины*/
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


        private void обОказанныхУслугахToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ОказанныеУслугиМесяц f1 = new ОказанныеУслугиМесяц();
            f1.Show();
        }

        private void обОказанныхУслугахToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ОказанныеУслугиГод f2 = new ОказанныеУслугиГод();
            f2.Show();
        }

        private void оРасходеВакцинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            РасходВакциныМесяц f3 = new РасходВакциныМесяц();
            f3.Show();
        }

        private void оРасходеВакцинToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            РасходВакцинГод f4 = new РасходВакцинГод();
            f4.Show();
        }

        private void оПрививкахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СделаноПрививокМесяц f5 = new СделаноПрививокМесяц();
            f5.Show();
        }

        private void оПрививкахToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            СделаноПрививокГод f6 = new СделаноПрививокГод();
            f6.Show();
        }

        private void оЗарплатахСотрудникамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВыплаченоЗарплатМесяц f7 = new ВыплаченоЗарплатМесяц();
            f7.Show();
        }

        private void оЗарплатахСотрудникамToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ВыплаченоЗарплатГод f8 = new ВыплаченоЗарплатГод();
            f8.Show();
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

        private void просмотрДоговоровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ЗавПросмотрДоговоров form = new ЗавПросмотрДоговоров();
            form.Show();
            this.Close();
        }
    }
}
