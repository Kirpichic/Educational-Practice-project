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
    public partial class ВыплаченоЗарплатГод : Form
    {
        public static string conStr = "server=127.0.0.1;user=user15;database=rubrum_crucis_database;password=151515";
        public MySqlConnection conn = new MySqlConnection(conStr);

        public ВыплаченоЗарплатГод()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ВыплаченоЗарплатГод_Load(object sender, EventArgs e)
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

        private readonly string YslygiZaGod = @"C:\Users\Mighty kitten\Desktop\Для уп\ЗП\зп за год.docx";

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
