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
    public partial class Titul : Form
    {
        public Menu Next_form = new Menu();

       
        public Titul()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void Titul_Load(object sender, EventArgs e)
        {

        }

     
        private void label10_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Titul_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
    }
}
