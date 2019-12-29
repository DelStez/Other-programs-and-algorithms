using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markovs
{
    public partial class Form1 : Form
    {
        public static List<string> InputWord = new List<string>();
        public static List<string> Steps = new List<string>();
        public static List<string> StrForReplace = new List<string>();
        public static List<bool> StopOrCont= new List<bool>();
        public static List<string> StrReplaceOn = new List<string>();
        public static int SizeOfWord;
        public static string inputFromBox;
        public Form1()
        {
            InitializeComponent();
                
        }
        private static string Markovs()
        { 

            for (int i = 0; i < StrForReplace.Count();)
            {
                string step = inputFromBox.Replace(" ", "");
                
                if (inputFromBox.Contains(StrForReplace[i].ToString()))
                {
                    string temp = StrForReplace[i].ToString();
                    int index = inputFromBox.IndexOf(temp);
                    inputFromBox = inputFromBox.Remove(index, temp.Length).Insert(index, StrReplaceOn[i].ToString());
                    if (StopOrCont[i])
                    {
                        step += (" " + "|->" + " " + inputFromBox.Replace(" ", ""));
                        Steps.Add(step);
                        break;

                    }
                    else
                    {
                        step += " " + "->" + inputFromBox.Replace(" ", "");
                        Steps.Add(step);
                    }
                    i = 0;
                    

                }
                else i++;
            }
            return inputFromBox;
        }
        public static void Cleaning() 
        {
            InputWord.Clear();
            StrForReplace.Clear();
            Steps.Clear();
            StopOrCont.Clear();
            StrReplaceOn.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cleaning();
            textBox2.Clear();
            inputFromBox = " " + textBox1.Text;
            SizeOfWord = InputWord.Count();
            for (int i = 0; i < inputFromBox.Length; i++)
            {
                InputWord.Add(inputFromBox[i].ToString());
            }
            for (int j = 0; j < dataGridView1.RowCount; j++)
            { 
                if (dataGridView1.Rows[j].Cells[0].Value != null || dataGridView1.Rows[j].Cells[2].Value != null)
                {
                    StrForReplace.Add(dataGridView1.Rows[j].Cells[0].Value == null ? " " : dataGridView1.Rows[j].Cells[0].Value.ToString());
                    if (dataGridView1.Rows[j].Cells[1].FormattedValue.ToString() == "|->") StopOrCont.Add(true);
                    else StopOrCont.Add(false);
                    string temp = " ";
                    if (dataGridView1.Rows[j].Cells[2].Value != null) temp = dataGridView1.Rows[j].Cells[2].Value.ToString();
                    StrReplaceOn.Add(temp);
                }
            }
            Markovs();
            textBox1.Text = inputFromBox.Replace(" ","");
            foreach (string step in Steps)
            {
                textBox2.Text += (step+"\r\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int indexCorsourRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                if (indexCorsourRow != 0) dataGridView1.Rows.Insert(indexCorsourRow - 1, 1);
                else dataGridView1.Rows.Insert(0);

            }
            else dataGridView1.Rows.Add();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1) dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

      
    }
}
