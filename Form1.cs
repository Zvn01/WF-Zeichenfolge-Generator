using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Zeichenfolge_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            var pwLength = Convert.ToInt32(numericUpDown1.Value);

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            
            if (specialChars_yes.Checked)
            {
                chars += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            }

                Random rnd = new Random();
            string password = new string(Enumerable.Repeat(chars, pwLength)
                                          .Select(s => s[rnd.Next(s.Length)])
                                          .ToArray());

            textBox1.Text = password;
        }

        private void clipBoard_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);  
                textBox1.SelectAll();
            }
        }

    }
}
