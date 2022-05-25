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

namespace Rogozin_yp02.ЗавОтделения
{
    public partial class ЗавПросмотрДоговоров : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public ЗавПросмотрДоговоров()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ЗавПросмотрДоговоров_Load(object sender, EventArgs e)
        {
            /*Загрузка таблицы Договора*/
            string query0 = "SELECT * FROM договора";
            MySqlCommand command0 = new MySqlCommand(query0, conn);
            MySqlDataReader reader0 = command0.ExecuteReader();

            List<string[]> data0 = new List<string[]>();
            while (reader0.Read())
            {
                data0.Add(new string[10]);

                data0[data0.Count - 1][0] = reader0.GetInt64(0).ToString();
                data0[data0.Count - 1][1] = reader0.GetDateTime(1).ToShortDateString();
                data0[data0.Count - 1][2] = reader0.GetInt64(2).ToString();
                data0[data0.Count - 1][3] = reader0.GetInt64(3).ToString();
                data0[data0.Count - 1][4] = reader0.GetInt64(4).ToString();
                data0[data0.Count - 1][5] = reader0.GetString(5);
                data0[data0.Count - 1][6] = reader0.GetDecimal(6).ToString();
                data0[data0.Count - 1][7] = reader0.GetString(7);
                data0[data0.Count - 1][8] = reader0.GetInt64(8).ToString();
                data0[data0.Count - 1][9] = reader0.GetString(9);
            }

            reader0.Close();

            foreach (string[] f in data0)
                dataGridView4.Rows.Add(f);
            /*Загрузка таблицы Договора*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ЗавОсн fr = new ЗавОсн();
            fr.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enter form = new Enter();
            form.Show();
            this.Close();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
