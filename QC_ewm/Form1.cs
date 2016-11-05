using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EWMCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + "ewm.png";
            Bitmap map = EWMCode.ToQRCode(richTextBox1.Text, filename);
            Bitmap temp = new Bitmap(map);
            pictureBox1.Image = temp;
            temp.Save(filename);

        }

        private void btnshibie_Click(object sender, EventArgs e)
        {
            string text = EWMCode.FromQRCode(new Bitmap(pictureBox1.Image));
            richTextBox2.Text = text;
        }
    }
}
