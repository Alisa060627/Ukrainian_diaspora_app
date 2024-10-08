using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vypuskna
{
    public partial class Card3 : Form
    {
        public Card3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українська діаспора в Канаді");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в США");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Німеччина");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Австрія");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void Card3_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Українці в Африці");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Zmist Next_form = new Zmist("Узбекістан");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {

            Zmist Next_form = new Zmist("Туркменістан");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();
        }

        private void Card3_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
