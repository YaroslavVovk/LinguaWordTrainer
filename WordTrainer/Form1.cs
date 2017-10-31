using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTrainer
{
    public partial class Form1 : Form
    {
        string path = @"D:\Projects\WordTrainer\WordTrainer\Words1.txt";
        DataParser parser;
        List<MyDictionary> dic;
       


        public Form1()
        {
            InitializeComponent();
            InializationBlock();

        }
        public void InializationBlock()
        {
            parser = new DataParser();
            dic = new List<MyDictionary>();

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("File cannot exist");
                }
                else
                {
                    dic = parser.ReadTextData(path);
                    SetListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SetListView()
        {
            try
            {
                if (dic == null)
                { throw new NullReferenceException("Dictionary cannot exist"); }
                else
                {                  
                    foreach (var item in dic)
                    {
                        ListViewItem lvi = new ListViewItem(item.EngWord);
                        lvi.SubItems.Add(item.RusWord);
                        view_Dictionary.Items.Add(lvi);

                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            OptionForm optForm = new OptionForm();
            optForm.ShowDialog();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

        }
    }
}
