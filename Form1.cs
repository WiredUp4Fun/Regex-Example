using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexExample
{
    public partial class FormRegexExample : Form
    {
        public FormRegexExample()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                Regex rgx = new Regex(textBoxFind.Text, RegexOptions.Multiline);

                MatchCollection matches = rgx.Matches(richTextBox1.Text);

                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;

                foreach (Match match in matches)
                {
                    richTextBox1.Select(match.Index, match.Length);
                    richTextBox1.SelectionBackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
