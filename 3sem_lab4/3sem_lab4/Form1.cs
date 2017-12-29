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

namespace _3sem_lab4
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
            string word = this.textBoxSearchWord.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();

                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
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
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
    }
}
