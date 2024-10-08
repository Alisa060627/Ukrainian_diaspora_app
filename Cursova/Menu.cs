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
    public partial class Menu : Form
    {

        public First Next1_form = new First ();
        public Second Next2_form = new Second();
        public Third Next3_form = new Third();
        public Fourth Next4_form = new Fourth();
        public Menu()
        {
            InitializeComponent();
        }

       

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
          
            Next1_form.StartPosition = FormStartPosition.CenterScreen;
            Next1_form.Show();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.Gold;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.MidnightBlue;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Next2_form.StartPosition = FormStartPosition.CenterScreen;
            Next2_form.Show();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.Gold;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.MidnightBlue;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Next3_form.StartPosition = FormStartPosition.CenterScreen;
            Next3_form.Show();

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Gold;

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.MidnightBlue;
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Next4_form.StartPosition = FormStartPosition.CenterScreen;
            Next4_form.Show();

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.Gold;

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.MidnightBlue;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  Base Next_form = new Base();
        Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
