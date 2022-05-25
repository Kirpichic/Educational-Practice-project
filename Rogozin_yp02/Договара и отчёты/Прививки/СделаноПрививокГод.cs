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
using Word = Microsoft.Office.Interop.Word;

namespace Rogozin_yp02
{
    public partial class СделаноПрививокГод : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public СделаноПрививокГод()
        {
            InitializeComponent();
            conn.Open();
        }

        private void СделаноПрививокГод_Load(object sender, EventArgs e)
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
                dataGridView1.Rows.Add(z);
            /*Загрузка таблицы Услуги*/
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

        private readonly string YslygiZaGod = @"C:\Users\Mighty kitten\Desktop\Для уп\Прививки\Прививки за год.docx";

        private void button1_Click(object sender, EventArgs e)
        {
            //Данные в программе
            var God = textBox3.Text;
            var Itogo = textBox1.Text;
            var Summ = textBox5.Text;
            //Данные в программе

            //Word Export
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                //Замена данных в форме, при помощи метода ReplaceWordStub
                var wordDocument = wordApp.Documents.Open(YslygiZaGod);
                ReplaceWordStub("{God}", God, wordDocument);
                ReplaceWordStub("{Itogo}", Itogo, wordDocument);
                ReplaceWordStub("{Summ}", Summ, wordDocument);

                //Сохранение документа
                wordDocument.SaveAs(@"" + textBox2.Text + textBox4.Text + ".docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        //Метод поиска и замены элемента в вордовском документе
        private void ReplaceWordStub(string str, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: str, ReplaceWith: text);
        }
    }
}
