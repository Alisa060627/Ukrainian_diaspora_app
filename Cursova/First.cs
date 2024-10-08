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
    public partial class First : Form
    {
        public Card1 Next1_form = new Card1();
        public First()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;
        private void First_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path + "\\Перша хвиля української еміграції.htm");

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Next1_form.StartPosition = FormStartPosition.CenterScreen;
            Next1_form.Show();

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightYellow;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSteelBlue;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void First_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
