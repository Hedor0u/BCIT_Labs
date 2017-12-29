using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace _3sem_5lab
{
    public partial class Form1 : Form
    {
        List<String> list = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReadText_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовый файл|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();

                string text = File.ReadAllText(fd.FileName);

                char[] separators = new char[] {' ', '.', ',', '!', '?', '/', '\t', '\n'};

                string[] textArray = text.Split(separators);

                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();

                    if (!list.Contains(str)) list.Add(str);
                }

                t.Stop();
                this.textBoxReadTime.Text = t.Elapsed.ToString();
            }

            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void buttonSearchWord_Click(object sender, EventArgs e)
        {
            this.listBoxFoundWords.BeginUpdate();
            this.listBoxFoundWords.Items.Clear();
            this.listBoxFoundWords.EndUpdate();
            string word = this.textBoxSearchWord.Text.Trim();

            string distStr = this.textBoxDistance.Text.Trim();

            int dist;

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0 && !string.IsNullOrWhiteSpace(distStr) && int.TryParse(distStr, out dist))
            {
                string wordUpper = word.ToUpper();

                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    //MessageBox.Show(Distance(str.ToUpper(), wordUpper).ToString());
                    if (Distance(str.ToUpper(),wordUpper) <= dist)
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.textBoxSearchTime.Text = t.Elapsed.ToString();

                this.listBoxFoundWords.BeginUpdate();

                foreach (string str in tempList)
                {
                    this.listBoxFoundWords.Items.Add(str);
                }
                this.listBoxFoundWords.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл, ввести слово для поиска и указать максимальное расстояние между словами");
            }
        }

        private void textBoxDistance_TextChanged(object sender, EventArgs e)
        {

        }

        public static int Distance(string str1, string str2)
        {
            if ((str1 == null) || (str2 == null)) return -1;

            int str1Len = str1.Length;
            int str2Len = str2.Length;

            if ((str1Len == 0) && (str2Len == 0)) return 0;
            else if (str1Len == 0) return str2Len;
            else if (str2Len == 0) return str1Len;

            string string1 = str1.ToUpper();
            string string2 = str2.ToUpper();

            int[,] matrix = new int[str1Len + 1, str2Len + 1];
            for (int i = 0; i <= str1Len; ++i) matrix[i, 0] = i;
            for (int j = 0; j <= str2Len; ++j) matrix[0, j] = j;

            for (int i = 1; i <= str1Len; ++i)
            {
                for (int j = 1; j <= str2Len; ++j)
                {
                    int symbEqual = (string1.Substring(i - 1, 1) == string2.Substring(j - 1, 1) ? 0 : 1);
                    int ins = matrix[i, j - 1] + 1;
                    int del = matrix[i - 1, j] + 1;
                    int subst = matrix[i - 1, j - 1] + symbEqual;

                    matrix[i, j] = Math.Min(Math.Min(ins, del), subst);

                    if ((i > 1) && (j > 1) && (string1.Substring(i - 1, 1) == string2.Substring(j - 2, 1)) && (string1.Substring(i - 2, 1) == string2.Substring(j - 1, 1)))
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
                    }
                }
            }
            return matrix[str1Len, str2Len];
        }
    }
}
