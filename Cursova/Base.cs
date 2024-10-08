using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vypuskna
{
    public partial class Base : Form
    {
        public static string nameXMLfile = "Base3.xml";
        DataSet ds;
        DataView dv1;
      
        public static int currentRow = 0;
   
        public Base()
        {
            InitializeComponent();
        }
        bool x;
        private void Base_Load(object sender, EventArgs e)
        {
            x = false;
            nameXMLfile = "Base3.xml";
            LoadXmFile();
            dv1.Sort = "Країна";
        }
        void LoadXmFile()
        {
            ds = new DataSet();
            FileStream fsReadXml = new FileStream(nameXMLfile, FileMode.Open);
            ds.ReadXml(fsReadXml);
            fsReadXml.Close();
            dv1 = new DataView(ds.Tables[0]);
            dataGridView1.DataSource = dv1;
            string s = dataGridView1.Rows[0].Cells[0].ToString();



            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Назва країни";
            dataGridView1.Columns[2].HeaderText = "Кількість людей в діаспорі";
            dataGridView1.Columns[3].HeaderText = "Кількість навчальних закладів";
            dataGridView1.Columns[4].HeaderText = "Рік заснування";
            dataGridView1.Columns[5].HeaderText = "Перші люди";
            dataGridView1.Columns[6].HeaderText = "Церкви діаспори";


            currentRow = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = dataGridView1.Width / 2/3-8;
        }
            string[] nazvaPolia = new string[] { "Країна", "Кількість діаспори", "Кількість навчальних закладів", "Рік започаткування діаспори","Перша людина діаспори", "Парафії української церкви" };
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = true;
            if (comboBox1.Text != "")
            {
                dv1.Sort = nazvaPolia[comboBox1.SelectedIndex] + " DESC";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text != null)
            {
                dv1.Sort = nazvaPolia[comboBox1.SelectedIndex];
                if (radioButton2.Checked)
                {
                    dv1.Sort += " DESC";

                }
                
               
            }
           


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = false;
            if (comboBox1.Text != "")
            {
                dv1.Sort = nazvaPolia[comboBox1.SelectedIndex];
            }
        }

        private void заКраїноюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введіть назву країни");
            dv1.Sort = "Країна";
            int index = dv1.Find(s);
            if (index != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("Такої країни в базі немає");
            }
        }

        private void заКраїноюToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            dv1.RowFilter = "";
        }

        private void Base_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (x == true & x == false)
            {
                if (nazvaPolia[comboBox1.SelectedIndex] == "Країна")
                {
                    if (x == true)
                    {
                        dv1.Sort = nazvaPolia[comboBox1.SelectedIndex] + " DESC";
                    }
                    if (x == false)
                    {
                        dv1.Sort = "Країна";
                    }
                    if (e.RowIndex == dv1.Find("Польща"))
                    {
                        Zmist Next_form = new Zmist("Польща");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Марокко"))
                    {
                        Zmist Next_form = new Zmist("Українці в Африці");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Словаччина"))
                    {
                        Zmist Next_form = new Zmist("Чехословаччина");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("ПАР"))
                    {
                        Zmist Next_form = new Zmist("Українці в Африці");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Єгипет"))
                    {
                        Zmist Next_form = new Zmist("Українці в Африці");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Канада"))
                    {
                        Zmist Next_form = new Zmist("Українська діаспора в Канаді");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("США"))
                    {
                        Zmist Next_form = new Zmist("Українці в США");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Австралія"))
                    {
                        Zmist Next_form = new Zmist("Українці в Австралії");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Франція"))
                    {
                        Zmist Next_form = new Zmist("Франція");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Німеччина"))
                    {
                        Zmist Next_form = new Zmist("Німеччина");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Росія"))
                    {
                        Zmist Next_form = new Zmist("Країни колишнього СРСР");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Чехія"))
                    {
                        Zmist Next_form = new Zmist("Чехословаччина");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Австрія"))
                    {
                        Zmist Next_form = new Zmist("Австрія");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Узбекістан"))
                    {
                        Zmist Next_form = new Zmist("Узбекістан");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Туркменія"))
                    {
                        Zmist Next_form = new Zmist("Туркменістан");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Китай"))
                    {
                        Zmist Next_form = new Zmist("Українці на Далекому Сході");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Ізраїль"))
                    {
                        Zmist Next_form = new Zmist("Ізраїль");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Бразилія"))
                    {
                        Zmist Next_form = new Zmist("Українці в Бразилії");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Аргентина"))
                    {
                        Zmist Next_form = new Zmist("Українці в Аргентині");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                    if (e.RowIndex == dv1.Find("Киргистан"))
                    {
                        Zmist Next_form = new Zmist("Киргистан");

                        Next_form.StartPosition = FormStartPosition.CenterScreen;
                        Next_form.Show();

                    }
                }
            }
            else
            {
                if (e.RowIndex == dv1.Find("Польща"))
                {
                    Zmist Next_form = new Zmist("Польща");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Марокко"))
                {
                    Zmist Next_form = new Zmist("Українці в Африці");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Словаччина"))
                {
                    Zmist Next_form = new Zmist("Чехословаччина");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("ПАР"))
                {
                    Zmist Next_form = new Zmist("Українці в Африці");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Єгипет"))
                {
                    Zmist Next_form = new Zmist("Українці в Африці");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Канада"))
                {
                    Zmist Next_form = new Zmist("Українська діаспора в Канаді");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("США"))
                {
                    Zmist Next_form = new Zmist("Українці в США");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Австралія"))
                {
                    Zmist Next_form = new Zmist("Українці в Австралії");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Франція"))
                {
                    Zmist Next_form = new Zmist("Франція");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Німеччина"))
                {
                    Zmist Next_form = new Zmist("Німеччина");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Росія"))
                {
                    Zmist Next_form = new Zmist("Країни колишнього СРСР");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Чехія"))
                {
                    Zmist Next_form = new Zmist("Чехословаччина");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Австрія"))
                {
                    Zmist Next_form = new Zmist("Австрія");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Узбекістан"))
                {
                    Zmist Next_form = new Zmist("Узбекістан");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Туркменія"))
                {
                    Zmist Next_form = new Zmist("Туркменістан");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Китай"))
                {
                    Zmist Next_form = new Zmist("Українці на Далекому Сході");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Ізраїль"))
                {
                    Zmist Next_form = new Zmist("Ізраїль");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Бразилія"))
                {
                    Zmist Next_form = new Zmist("Українці в Бразилії");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Аргентина"))
                {
                    Zmist Next_form = new Zmist("Українці в Аргентині");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }
                if (e.RowIndex == dv1.Find("Киргистан"))
                {
                    Zmist Next_form = new Zmist("Киргистан");

                    Next_form.StartPosition = FormStartPosition.CenterScreen;
                    Next_form.Show();

                }

            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();

        private void Base_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }

      
    }

