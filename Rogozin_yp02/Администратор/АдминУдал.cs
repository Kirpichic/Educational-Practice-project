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
    public partial class АдминУдал : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public АдминУдал()
        {
            InitializeComponent();
            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // запрос на удаление сотрудника
            string сотрудники = "DELETE FROM сотрудники WHERE id = " + Введите_id.Text + ";";
            MySqlCommand command = new MySqlCommand(сотрудники, conn);
            command.ExecuteNonQuery();
            // запрос на удаление сотрудника

            //Отчистка DataGridView
            dataGridView2.Rows.Clear();
            //Отчистка DataGridView

            /*Загрузка таблицы Сотрудники*/
            string query1 = "SELECT * FROM сотрудники";
            MySqlCommand command3 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = command3.ExecuteReader();

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

        private void АдминУдал_Load(object sender, EventArgs e)
        {
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
                dataGridView4.Rows.Add(z);
            /*Загрузка таблицы Услуги*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            АдминОсн fr = new АдминОсн();
            fr.Show();
            this.Close();
        }
    }
}
