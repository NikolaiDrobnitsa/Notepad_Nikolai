using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backuyp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addtabcontros();
        }
        private void addtabcontros()
        {
            this.Controls.Add(tabControl1);
            this.tabControl1.Size = new Size(this.Size.Width, this.Size.Height);
            this.tabControl1.Location = new Point(0, 55);
            //this.tabControl1.Controls.Add(create_tabpage("hello tabpage", "TabPage", Color.Gold));
            this.tabControl1.Controls.Add(new C_Tag_With_TextBox("HELLA","sss",this.tabControl1.Width,this.tabControl1.Height));

        }
        TabControl tabControl1 = new TabControl();
        int check;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedTab.Size
            //label1.Text = this.tabControl1.TabPages.IndexOf();
            //this.tabControl1.TabPages.IndexOf;
            this.tabControl1.Size = new Size(this.Width, this.Height);
            label1.Text = check.ToString();
        }
        private TabPage create_tabpage(string text, string title, Color tab_color)
        {

            TabPage newTabPage = new TabPage();
            newTabPage.Text = title;
            newTabPage.Controls.Add(new TextBox() { Multiline = true, Size = new Size(400, 400), BackColor = tab_color, Text = text });
            

            return newTabPage;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(tabControl1);
            this.tabControl1.Size = new Size(this.Size.Width, this.Size.Height);
            this.tabControl1.Location = new Point(0, 55);
            this.tabControl1.Controls.Add(create_tabpage("hello tabpage", "TabPage", Color.Gold));

            //this.tabControl1.Controls.Add(new C_Tag_With_TextBox("HELLA", "sss", this.tabControl1.Width, this.tabControl1.Height));

        }
    }
}
