using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP
{
    public partial class FormMP : Form
    {
        public FormMP()
        {
            InitializeComponent();
            tableOfInfo.Rows.Add();
            tableOfInfo.Rows[0].Cells[0].Value = "1";
        }
        protected char[] moveSymbol = { '>', '<', '0','1', '?','.' }; // right, left, stay
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
                for (int i = 0; i < tableOfInfo.Rows.Count;)
                {
                    var command = tableOfInfo[1, i].Value.ToString();
                    if (command == '?'.ToString())
                    {
                        if (tableOfInfo[1, i].Value != null)
                        {
                            string[] v = tableOfInfo[1, i].Value.ToString().Split(',').ToArray();
                            if (v[0] != "" || v[1] != "")
                            {
                                i = (dataGridView2[midlle,0].Value.ToString() != " " ? Convert.ToInt32(v[1]) : Convert.ToInt32(v[0]));
                            }
                            else
                            {
                                MessageBox.Show("Не удалось расшифровать переход");
                                end = true; break;
                            }
                        }

                    }
                    else if (command == '>'.ToString())
                    {
                        midlle++;
                        if (tableOfInfo[2, i].Value != null)
                        {
                            i = Convert.ToInt32(tableOfInfo[2, i].Value.ToString());
                        }
                        else
                        {
                            i++;
                        }
                        
                    }
                    else if (command == '<'.ToString())
                    {
                        midlle--;
                        if (tableOfInfo[2, i].Value != null)
                        {
                            i = Convert.ToInt32(tableOfInfo[2, i].Value.ToString());
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (command == '0'.ToString())
                    {
                        if (dataGridView2[midlle, 0].Value.ToString() != " ")
                        {
                            dataGridView2[midlle, 0].Value = " ";
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("Повторное стирание метки!");
                            end = true; break;
                        }
                    }
                    else if (command == '1'.ToString())
                    {
                        if (dataGridView2[midlle, 0].Value.ToString() != "▌")
                        {
                            dataGridView2[midlle, 0].Value = "▌";
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("Повторное установка метки!");
                            end = true; break;
                        }
                    }
                    else if (command == '.'.ToString())
                    {
                        MessageBox.Show("Конец программы");
                        end = true; break;
                    }
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
                dataGridView2.Rows[0].Cells[i].Value = " ";
                i++;
            }
            int x = dataGridView2.Columns[200 / 2].DisplayIndex;
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

                dataGridView2.Rows[0].Cells[i].Value = " ";
                i++;
            }
            int x = dataGridView2.Columns[200 / 2].DisplayIndex;
            dataGridView2.FirstDisplayedScrollingColumnIndex = x - dataGridView2.DisplayedColumnCount(true) / 2;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            Machine();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CleanTapeAnInstructions();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            tableOfInfo.Rows.Add();
            int u = tableOfInfo.Rows.Count;
            tableOfInfo.Rows[u-1].Cells[0].Value = u.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            tableOfInfo.Rows.RemoveAt(tableOfInfo.Rows.Count - 1);
        }

        private void tableOfInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString() != " ")
            {
                dataGridView2[e.ColumnIndex, e.RowIndex].Value = " ";
            }
            else
                dataGridView2[e.ColumnIndex, e.RowIndex].Value = "▌";
            
        }
    }
}
