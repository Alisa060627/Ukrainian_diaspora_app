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
    public partial class Fourth : Form
    {
        public Card4 Next1_form = new Card4();
        public Fourth()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;
        private void Fourth_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path + "\\Четверта хвиля української еміграції.htm");
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Next1_form.StartPosition = FormStartPosition.CenterScreen;
            Next1_form.Show();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSkyBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Goldenrod;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fourth_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
