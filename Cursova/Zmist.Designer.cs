namespace Vypuskna
{
    partial class Zmist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Українці в США");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Українська діаспора в Канаді");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Українці в Австралії");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Польща");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Чехословаччина");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Німеччина");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Австрія");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Франція");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Українці в Європі", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ізраїль");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Українці на Далекому Сході");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Туркменістан");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Узбекістан");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Киргистан");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Азія", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Країни колишнього СРСР");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Українці в Бразилії");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Українці в Аргентині");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Українці в Африці");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Українці в США";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Українська діаспора в Канаді";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "Українці в Австралії";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Польща";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Чехословаччина";
            treeNode6.Name = "Узел6";
            treeNode6.Text = "Німеччина";
            treeNode7.Name = "Узел7";
            treeNode7.Text = "Австрія";
            treeNode8.Name = "Узел8";
            treeNode8.Text = "Франція";
            treeNode9.Name = "Узел3";
            treeNode9.Text = "Українці в Європі";
            treeNode10.Name = "Узел10";
            treeNode10.Text = "Ізраїль";
            treeNode11.Name = "Узел11";
            treeNode11.Text = "Українці на Далекому Сході";
            treeNode12.Name = "Узел1";
            treeNode12.Text = "Туркменістан";
            treeNode13.Name = "Узел2";
            treeNode13.Text = "Узбекістан";
            treeNode14.Name = "Узел2";
            treeNode14.Text = "Киргистан";
            treeNode15.Name = "Узел9";
            treeNode15.Text = "Азія";
            treeNode16.Name = "Узел12";
            treeNode16.Text = "Країни колишнього СРСР";
            treeNode17.Name = "Узел0";
            treeNode17.Text = "Українці в Бразилії";
            treeNode18.Name = "Узел1";
            treeNode18.Text = "Українці в Аргентині";
            treeNode19.Name = "Узел0";
            treeNode19.Text = "Українці в Африці";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode9,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(273, 609);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(44, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "До меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.Location = new System.Drawing.Point(308, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1212, 682);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.TabStop = false;
            // 
            // Zmist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1605, 706);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zmist";
            this.ShowIcon = false;
            this.Text = "Основна інформація про українську діаспору в різних країнах";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zmist_FormClosing);
            this.Load += new System.EventHandler(this.Zmist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}