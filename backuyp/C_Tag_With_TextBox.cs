using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backuyp
{
    class C_Tag_With_TextBox : TabPage
    {
        public int widht_textbox { get; set; }
        public int height_textbox { get; set; }
        public C_Tag_With_TextBox(string title, string PathToImage, int Widht_form, int Height_form)
        {


            this.Text = title;
            //this.Size = new Size(300, 300);
            this.Controls.Add(new RichTextBox() { Size = new Size(Widht_form, Height_form) });

            //this.Controls.Add(new PictureBox() { Image = i, Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.StretchImage });
            //this.Controls.Add(new Label() { Size = new Size(100, 20), Location = new Point(0, 110), Text = PathToImage });
            //this.Click += C_tab_with_image_Click;
            

        }
        
    }
}
