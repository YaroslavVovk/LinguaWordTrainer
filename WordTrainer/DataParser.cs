using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WordTrainer
{
    class DataParser
    {
        const string pattern = @"[A-Za-z]\s{2}\S\s{2}[А-Яа-я]";
        Regex regex;
        List<MyDictionary> dic;

        public List<MyDictionary> ReadTextData(string path)
        {
            dic = new List<MyDictionary>();
            regex = new Regex(pattern);
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (regex.IsMatch(line))
                        {
                            string[] str = line.Split(' ');
                            if (str.Length <= 5)
                                dic.Add(new MyDictionary() { EngWord = str[0], RusWord = str[4] });                  
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dic;
        }

    }
}
