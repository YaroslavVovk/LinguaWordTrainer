using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTrainer
{
    public partial class OptionForm : Form
    {
        int countElement = 0;
        public OptionForm(int countElement)
        {
            InitializeComponent();
            this.countElement = countElement;
            textBox1.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ConfigurationOptions.WordCount = int.Parse(textBox1.Text);
                ConfigurationOptions.FromEngtoRus = checkBox1.Checked;
                if (ConfigurationOptions.WordCount > countElement)
                {
                    MessageBox.Show("Count of word must be least than all worsd in dictionary");
                    ConfigurationOptions.WordCount = 0;
                }
                else
                {
                    MessageBox.Show("Options was applied");
                }
            }
            else
            {
                MessageBox.Show("Field is empty");
            }

        }
    }
}
