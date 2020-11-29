using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT
{
    public partial class FormMT : Form
    {
        public FormMT()
        {
            InitializeComponent();
            LongOfTape.SelectedIndex = 0;
            tableOfInfo.Rows.Add();
            tableOfInfo.Rows[0].Cells[0].Value = "q0";
           
            
        }
   
        string[,] Rules; 
        string alfabetstr;
        public void Machine()
        {
            int midlle = dataGridView2.CurrentCell.ColumnIndex;
            int State = 0;
            bool end = false;
            while (true)
            {

                if (end) break;
                string Val = dataGridView2.Rows[0].Cells[midlle].Value.ToString();

                for (int i = 1; i < tableOfInfo.Rows[State].Cells.Count;)
                {
                    if (tableOfInfo.Columns[i].HeaderText.ToString() == Val)
                    {
                        List<string>temp = new List<string>(tableOfInfo.Rows[State].Cells[i].Value.ToString().Split(',').ToArray());
                        if(temp[0] != " ") dataGridView2.Rows[0].Cells[midlle].Value = temp[0];
                        if (temp[1] == "R") midlle++;
                        else if (temp[1] == "L") midlle--; 
                        dataGridView2.CurrentCell = dataGridView2[midlle, 0];
                        if (temp[2] != "!")
                        {
                            if (temp[2].ToString() != " " && Convert.ToInt32(temp[2].Replace("q", "")) != State)
                            {
                                State = Convert.ToInt32(temp[2].Replace("q", ""));
                                break;
                            }
                        }
                        else { end = true; break; }
                         
                    }
                    i++;
                }

            }
        }
        void CreateTape() 
        {
            int i = 0;
            while (i < Convert.ToInt32(LongOfTape.SelectedItem))
            {
                DataGridViewTextBoxColumn k = new DataGridViewTextBoxColumn();
                k.HeaderText = (i - Convert.ToInt32(LongOfTape.SelectedItem) / 2).ToString();
                dataGridView2.Columns.Add(k);
                dataGridView2.Rows[0].Cells[i].Value = "_";
                i++;
            }
            int x = dataGridView2.Columns[Convert.ToInt32(LongOfTape.SelectedItem) / 2].DisplayIndex;
            dataGridView2.CurrentCell = dataGridView2[Convert.ToInt32(LongOfTape.SelectedItem) / 2, 0];
            dataGridView2.FirstDisplayedScrollingColumnIndex = x - dataGridView2.DisplayedColumnCount(true) / 2;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTape();            
           
        }
        void CleanTapeAnInstructions()
        {
            int i = 0;
            while (i < Convert.ToInt32(LongOfTape.SelectedItem))
            {
               
                dataGridView2.Rows[0].Cells[i].Value = "_";
                i++;
            }
            int x = dataGridView2.Columns[Convert.ToInt32(LongOfTape.SelectedItem) / 2].DisplayIndex;
            dataGridView2.CurrentCell = dataGridView2[Convert.ToInt32(LongOfTape.SelectedItem) / 2, 0];
            dataGridView2.FirstDisplayedScrollingColumnIndex = x - dataGridView2.DisplayedColumnCount(true) / 2;
            while (1 < tableOfInfo.Columns.Count - 1) tableOfInfo.Columns.RemoveAt(1);
            while (1 < tableOfInfo.Rows.Count) tableOfInfo.Rows.RemoveAt(1);
        }
       private void getButton_Click(object sender, EventArgs e)
        {
            CleanTapeAnInstructions();
            alfabetstr = (Alphabet.Text).ToString();
            for (int j = alfabetstr.Length - 1; j >= 0; j--)
            {
                DataGridViewTextBoxColumn k = new DataGridViewTextBoxColumn();
                k.HeaderText = alfabetstr[j].ToString();
                tableOfInfo.Columns.Insert(1, k);
            }

            string StrForMachine = (InputBox.Text).ToString();
            for (int i = 0; i < StrForMachine.Length; i++)
            {
                dataGridView2[(Convert.ToInt32(LongOfTape.SelectedItem) / 2) + i, 0].Value = StrForMachine[i];
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Machine();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CleanTapeAnInstructions();
            Alphabet.Clear();
            InputBox.Clear();
            LongOfTape.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            tableOfInfo.Rows.Add();
            int u = tableOfInfo.Rows.Count - 1;
            tableOfInfo.Rows[u].Cells[0].Value = "q" + u.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            tableOfInfo.Rows.RemoveAt(tableOfInfo.Rows.Count - 1);
        }

        private void LongOfTape_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            CreateTape();
        }
    }
}
