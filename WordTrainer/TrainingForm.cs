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
     partial class TrainingForm : Form
    {
        public static Random random;
        public int[] indexs;
        public int index = -1;
        List<MyDictionary> dic;
        int size;
        public bool wasAsked = false;
        public bool wasAnswered = false;
        public TrainingForm(List<MyDictionary> dic)
        {
            InitializeComponent();
            random = new Random();
            size =  ConfigurationOptions.WordCount;
            indexs = new int[size];
            this.dic = dic;
            GenerateIndexes();
            AskWord(ref index);
        }


        public void GenerateIndexes()
        {
            for (int i = 0; i < size; i++)
            {
                indexs[i] = random.Next(0, dic.Count);
            }
        }

        public void AskWord(ref int index)
        {          
            lb_Tranlation.Visible = false;
            index++;
            if (indexs.Length == 0)
            {
                MessageBox.Show("All words was trained");
            }
 

            else if (index < indexs.Length)
            {
                int elementIndex = indexs[index];
                lb_Word.Text = dic[elementIndex].EngWord;
                lb_Tranlation.Text = dic[elementIndex].RusWord;
            }

            else
            {
                index = 0;
            }
            wasAsked = true;
            wasAnswered = false;


        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(wasAnswered)
                AskWord(ref index);
        }

        private void btn_Dunno_Click(object sender, EventArgs e)
        {
            lb_Tranlation.Visible = true;
            wasAnswered = true;
            wasAsked = false;
        }

        private void btn_Know_Click(object sender, EventArgs e)
        {
            lb_Tranlation.Visible = true;
            if (wasAsked&&indexs.Length!=0)
            {
                int elementIndex = indexs[index];
                indexs = indexs.Where(val => val != elementIndex).ToArray();
                index--;
            }
            wasAnswered = true;
            wasAsked = false;
        }
    }
}
