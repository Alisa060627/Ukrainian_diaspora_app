using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vypuskna
{
    public partial class Card1 : Form
    {
        
    
       
        public Card1()
        {
            InitializeComponent();
        }

        private void Card_Load(object sender, EventArgs e)
        {

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
            Zmist Next_form = new Zmist("Країни колишнього СРСР");

            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void Card1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
