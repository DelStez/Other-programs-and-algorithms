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
            tableOfInfo.Rows.Add();
            tableOfInfo.Rows[0].Cells[0].Value = "q0";
           
            
        }

        protected char[] moveSymbol = { '>', '<', '.' }; // right, left, stay
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
                        try
                        {
                            var cellCommand = tableOfInfo.Rows[State].Cells[i].Value.ToString();
                            string[] symbolAndNextState = cellCommand.Split(moveSymbol).ToArray();
                            var moveVector = Array.Find(cellCommand.ToCharArray(), x => moveSymbol.Contains(x)).ToString();
                            dataGridView2.Rows[0].Cells[midlle].Value = symbolAndNextState[0];
                            if (moveVector == moveSymbol[0].ToString()) midlle++;
                            else if (moveVector == moveSymbol[2].ToString()) midlle--;
                            dataGridView2.CurrentCell = dataGridView2[midlle, 0];

                            if (symbolAndNextState[1] != "!")
                            {
                                if (Convert.ToInt32(symbolAndNextState[1]) != State)
                                {
                                    State = Convert.ToInt32(symbolAndNextState[2]);
                                    break;
                                }
                            }
                            else { end = true; break; }
                        }
                        catch (System.NullReferenceException)
                        {
                            MessageBox.Show($"Нет команды в ячейке ( {tableOfInfo.Columns[i].HeaderText}, q{State})");
                            end = true; break;
                        }
                    }
                    i++;
                }

            }
        }
        void CreateTape() 
        {
            int i = 0;
            while (i <= 200)
            {
                DataGridViewTextBoxColumn k = new DataGridViewTextBoxColumn();
                k.HeaderText = (i - 200 / 2).ToString();
                dataGridView2.Columns.Add(k);
                dataGridView2.Rows[0].Cells[i].Value = "_";
                i++;
            }
            int x = dataGridView2.Columns[200/ 2].DisplayIndex;
            dataGridView2.CurrentCell = dataGridView2[200 / 2, 0];
            dataGridView2.FirstDisplayedScrollingColumnIndex = x - dataGridView2.DisplayedColumnCount(true) / 2;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTape();            
           
        }
        void CleanTapeAnInstructions()
        {
            int i = 0;
            while (i <= 200)
            {
               
                dataGridView2.Rows[0].Cells[i].Value = "_";
                i++;
            }
            int x = dataGridView2.Columns[200 / 2].DisplayIndex;
            dataGridView2.CurrentCell = dataGridView2[200 / 2, 0];
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
                dataGridView2[(200 / 2) + i, 0].Value = StrForMachine[i];
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

        private void tableOfInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var currentContent = tableOfInfo[e.ColumnIndex, e.RowIndex].Value.ToString();
                Type type = e.GetType();
                if (!currentContent.Contains("q"))
                {
                    string[] c = currentContent.Split(moveSymbol).ToArray();
                    if (c.Length == 1)
                    {
                        MessageBox.Show("Не задана команда перехода");
                        tableOfInfo[e.ColumnIndex, e.RowIndex].Value = null;
                    }
                    else
                    {
                        if (c[1] != "!" && c[1] != "" && Convert.ToInt32(c[1]) > tableOfInfo.Rows.Count - 1)
                        {
                            MessageBox.Show("Неверный номер состояния");
                            tableOfInfo[e.ColumnIndex, e.RowIndex].Value = null;
                        }
                        else
                        {
                            string temp = "";
                            if (c[0] == "")
                                temp += tableOfInfo.Columns[e.ColumnIndex].HeaderText;
                            else
                            {
                                temp += c[0].ToString();
                            }
                            temp += Array.Find(currentContent.ToCharArray(), x => moveSymbol.Contains(x)).ToString();
                            if (c[1] == "")
                                temp += e.RowIndex.ToString();
                            else if (c[1] == "!" || c[1] != "" && Convert.ToInt32(c[1]) <= tableOfInfo.Rows.Count - 1)
                            {
                                temp += c[1].ToString();
                            }

                            tableOfInfo[e.ColumnIndex, e.RowIndex].Value = temp;
                        }                        
                    }
                }
            }
            catch (System.NullReferenceException){ }
        }
    }
}
