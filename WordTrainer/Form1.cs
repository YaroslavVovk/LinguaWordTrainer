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
    public partial class Form1 : Form
    {
        DataParser parser;

        public Form1()
        {
            InitializeComponent();
            InializationBlock();

        }
        public void InializationBlock()
        {
            parser = new DataParser();
            parser.ReadTextData(@"D:\Projects\WordTrainer\WordTrainer\Words1.txt");
        }

    }
}
