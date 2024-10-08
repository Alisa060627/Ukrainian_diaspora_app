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
    public partial class Zmist : Form
    {
        public Menu Next_form = new Menu();

        string com;
        public Zmist(string _com)
        {
            InitializeComponent();
            
            com = _com;
          
           
        }
        void Find(TreeNodeCollection Nodes, string str)
        {
            foreach (TreeNode tn in Nodes)
            {
                if (tn.Text == str)
                {
                    treeView1.Focus();
                    treeView1.SelectedNode = tn;
                }
                Find(tn.Nodes, str);
            }
        }
 
   
   
        string path = Application.StartupPath;
       public bool x;
      
        private void Zmist_Load(object sender, EventArgs e)
        {
            Find(treeView1.Nodes, com);

            x = false;
      
            if (com == "Українці в США")
                webBrowser1.Navigate(path + "\\Українці в США.htm");
            if (com == "Українська діаспора в Канаді")
                webBrowser1.Navigate(path + "\\Українська діаспора в Канаді.htm");
            if (com == "Українці в Австралії")
                webBrowser1.Navigate(path + "\\Українці в Австралії.htm");
            if (com == "Польща")
                webBrowser1.Navigate(path + "\\Польща.htm");
            if (com == "Чехословаччина")
                webBrowser1.Navigate(path + "\\Чехословаччина.htm");
            if (com == "Німеччина")
                webBrowser1.Navigate(path + "\\Німеччина.htm");
            if (com == "Австрія")
                webBrowser1.Navigate(path + "\\Австрія.htm");
            if (com == "Франція")
                webBrowser1.Navigate(path + "\\Франція.htm");
            if (com == "Країни колишнього СРСР")
                webBrowser1.Navigate(path + "\\Країни колишнього СРСР.htm");
            if (com == "Українці в Бразилії")
                webBrowser1.Navigate(path + "\\Українці в Бразилії.htm");
            if (com == "Українці в Аргентині")
                webBrowser1.Navigate(path + "\\Аргентина.htm");
            if (com == "Українці на Далекому Сході")
                webBrowser1.Navigate(path + "\\Українці на Далекому Сході.htm");
            if (com == "Ізраїль")
                webBrowser1.Navigate(path + "\\Ізраїль.htm");
            if (com == "Українці в Африці")
                webBrowser1.Navigate(path + "\\Українці в Африці.htm");
            if (com == "Туркменістан")
                webBrowser1.Navigate(path + "\\Туркменістан.htm");
            if (com == "Узбекістан")
                webBrowser1.Navigate(path + "\\Узбекістан.htm");
            if (com == "Киргистан")
                webBrowser1.Navigate(path + "\\Киргистан.htm");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            treeView1.SelectedNode.BackColor = Color.Transparent;
            if (x == false)
                {

                    if (com == "Українці в США")
                        webBrowser1.Navigate(path + "\\Українці в США.htm");
                    if (com == "Українці в Австралії")
                        webBrowser1.Navigate(path + "\\Українці в Австралії.htm");
                    if (com == "Українська діаспора в Канаді")
                        webBrowser1.Navigate(path + "\\Українська діаспора в Канаді.htm");

                    if (com == "Польща")
                        webBrowser1.Navigate(path + "\\Польща.htm");
                    if (com == "Чехословаччина")
                        webBrowser1.Navigate(path + "\\Чехословаччина.htm");
                    if (com == "Німеччина")
                        webBrowser1.Navigate(path + "\\Німеччина.htm");
                    if (com == "Австрія")
                        webBrowser1.Navigate(path + "\\Австрія.htm");
                    if (com == "Франція")
                        webBrowser1.Navigate(path + "\\Франція.htm");
                    if (com == "Країни колишнього СРСР")
                        webBrowser1.Navigate(path + "\\Країни колишнього СРСР.htm");
                    if (com == "Українці в Бразилії")
                        webBrowser1.Navigate(path + "\\Українці в Бразилії.htm");
                    if (com == "Українці в Аргентині")
                        webBrowser1.Navigate(path + "\\Аргентина.htm");
                    if (com == "Ізраїль")
                        webBrowser1.Navigate(path + "\\Ізраїль.htm");
                    if (com == "Українці на Далекому Сході")
                        webBrowser1.Navigate(path + "\\Українці на Далекому Сході.htm");
                    if (com == "Українці в Африці")
                        webBrowser1.Navigate(path + "\\Українці в Африці.htm");
                    if (com == "Туркменістан")
                        webBrowser1.Navigate(path + "\\Туркменістан.htm");
                    if (com == "Узбекістан")
                        webBrowser1.Navigate(path + "\\Узбекістан.htm");
                if (com == "Киргистан")
                    webBrowser1.Navigate(path + "\\Киргистан.htm");
            }
            else if (x== true)
                {

                com = treeView1.SelectedNode.Text;


                    if (com == "Українці в США")
                        webBrowser1.Navigate(path + "\\Українці в США.htm");
                    if (com == "Українці в Австралії")
                        webBrowser1.Navigate(path + "\\Українці в Австралії.htm");
                    if (com == "Українська діаспора в Канаді")
                        webBrowser1.Navigate(path + "\\Українська діаспора в Канаді.htm");

                    if (com == "Польща")
                        webBrowser1.Navigate(path + "\\Польща.htm");
                    if (com == "Чехословаччина")
                        webBrowser1.Navigate(path + "\\Чехословаччина.htm");
                    if (com == "Німеччина")
                        webBrowser1.Navigate(path + "\\Німеччина.htm");
                    if (com == "Австрія")
                        webBrowser1.Navigate(path + "\\Австрія.htm");
                    if (com == "Франція")
                        webBrowser1.Navigate(path + "\\Франція.htm");
                    if (com == "Країни колишнього СРСР")
                        webBrowser1.Navigate(path + "\\Країни колишнього СРСР.htm");
                    if (com == "Українці в Бразилії")
                        webBrowser1.Navigate(path + "\\Українці в Бразилії.htm");
                    if (com == "Українці в Аргентині")
                        webBrowser1.Navigate(path + "\\Аргентина.htm");
                    if (com == "Ізраїль")
                        webBrowser1.Navigate(path + "\\Ізраїль.htm");
                    if (com == "Українці на Далекому Сході")
                        webBrowser1.Navigate(path + "\\Українці на Далекому Сході.htm");
                    if (com == "Українці в Африці")
                        webBrowser1.Navigate(path + "\\Українці в Африці.htm");
                    if (com == "Туркменістан")
                        webBrowser1.Navigate(path + "\\Туркменістан.htm");
                    if (com == "Узбекістан")
                        webBrowser1.Navigate(path + "\\Узбекістан.htm");
                if (com == "Киргистан")
                    webBrowser1.Navigate(path + "\\Киргистан.htm");
            }
            
        }

        private void Zmist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

      

       
        private void button1_Click(object sender, EventArgs e)
        {
            Next_form.StartPosition = FormStartPosition.CenterScreen;
            Next_form.Show();

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            x = true;
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            x = true;
        }
    }
}
