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

namespace Rogozin_yp02.Администратор
{
    public partial class РегУдал : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public РегУдал()
        {
            InitializeComponent();
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // запрос на удаление клиента
            string клиенты = "DELETE FROM клиенты WHERE полис = " + Введите_полис.Text + ";";
            MySqlCommand command = new MySqlCommand(клиенты, conn);
            command.ExecuteNonQuery();
            // запрос на удаление клиента

            //Отчистка DataGridView
            dataGridView1.Rows.Clear();
            //Отчистка DataGridView

            /*Загрузка таблицы Клиенты*/
            string query = "SELECT * FROM клиенты";
            MySqlCommand command4 = new MySqlCommand(query, conn);
            MySqlDataReader reader = command4.ExecuteReader();

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            АдминОсн fr = new АдминОсн();
            fr.Show();
            this.Close();
        }

        private void РегУдал_Load(object sender, EventArgs e)
        {
            /*Загрузка таблицы Клиенты*/
            string query = "SELECT * FROM клиенты";
            MySqlCommand command1 = new MySqlCommand(query, conn);
            MySqlDataReader reader = command1.ExecuteReader();

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
                dataGridView4.Rows.Add(z);
            /*Загрузка таблицы Услуги*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // запрос на удаление услуги
            string услуги = "DELETE FROM услуги WHERE № = " + Введите_Ном.Text + ";";
            MySqlCommand command = new MySqlCommand(услуги, conn);
            command.ExecuteNonQuery();
            // запрос на удаление услуги

            //Отчистка DataGridView
            dataGridView4.Rows.Clear();
            //Отчистка DataGridView

            /*Загрузка таблицы Услуги*/
            string query2 = "SELECT * FROM услуги";
            MySqlCommand command5 = new MySqlCommand(query2, conn);
            MySqlDataReader reader2 = command5.ExecuteReader();

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
                dataGridView4.Rows.Add(z);
            /*Загрузка таблицы Услуги*/
        }
    }
}
