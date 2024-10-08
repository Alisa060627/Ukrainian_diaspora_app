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
    public partial class Third : Form
    {
        public Card3 Next1_form = new Card3();
        public Third()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Next1_form.StartPosition = FormStartPosition.CenterScreen;
            Next1_form.Show();
           
        }

        private void Third_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path + "\\Третя хвиля української еміграції.htm");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gold;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSkyBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Third_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
