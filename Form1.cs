using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Discretka_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N; // количество вершин графа

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelStart.Visible = false;
            textStart.Visible = false;
            buttonStart.Visible = false;

            labelExe.Visible = true;
            buttonExe.Visible = true;

            createMatrixSmejnosti();
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            matrix.ReadOnly = true;
            matrix.ClearSelection();

            labelExe.Visible = false;
            buttonExe.Visible = false;

            checkGraph(); 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelMatrix.Visible = false;
            matrix.Columns.Clear();
            matrix.ReadOnly = false;

            labelAnswer.Visible = false;
            textBoxAnswer.Visible = false;

            labelClear.Visible = false;
            buttonClear.Visible = false;

            labelStart.Visible = true;
            textStart.Clear();
            textStart.Visible = true;
            buttonStart.Visible = true;

            labelError1.Visible = false;
            labelError2.Visible = false;
            buttonError.Visible = false;
        }
        
        private void createMatrixSmejnosti() 
        {
            N = Convert.ToInt32(textStart.Text);
            matrix.RowCount = N;
            matrix.ColumnCount = N;

            foreach (DataGridViewColumn column in matrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < N; i++)
            {
                matrix.Columns[i].HeaderText = Convert.ToString(i + 1);
                matrix.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
            }
                 
            labelMatrix.Visible = true;
            matrix.Visible = true;
        }

        private List<List<int>> createlistsSmejnosti() 
        {
            List<List<int>> lists = new List<List<int>>();
            List<int> row = new List<int>();

            for (int r = 0; r < N; r++)
            {
                row = new List<int>();
                for (int c = 0; c < N; c++)
                {

                    if (Convert.ToInt32(matrix[c, r].Value) == 1)
                    {
                        row.Add(c);
                    }
                }
                lists.Add(row);
            }
            return lists;
        }

        private void checkGraph() 
        {
            bool check = true;
            List<List<int>> listsSmej = createlistsSmejnosti();

            //проверка 1: является ли граф связным
            Queue<int> q = new Queue<int>();
            List<int> noted = new List<int>();
            int top;
            q.Enqueue(1);
            noted.Add(1);

            while (q.Count != 0)
            {
                top = q.Dequeue();
                foreach (int t in listsSmej[top - 1])
                {
                    if (!noted.Contains(t + 1))
                    {
                        q.Enqueue(t + 1);
                        noted.Add(t + 1);
                    }
                }
            }

            if (noted.Count != N)
            {
                check = false;
            }
            else
            {
                //проверка 2: присутвуют ли нечетные вершины в графе 
                for (int n = 0; n < listsSmej.Count; n++)
                {
                    if (listsSmej[n].Count % 2 != 0)
                    {
                        check = false;
                        break;
                    }
                }
            }

            if (check)
            {
                buildEulerCycle(listsSmej);
            }
            else 
            {
                labelError1.Visible = true;
                labelError2.Visible = true;
                buttonError.Visible = true;
            }
        }

        private void buildEulerCycle(List<List<int>> lists) 
        {
            List<List<int>> listsSmej = lists; // списки смежности графа
            Stack<int> visited = new Stack<int>(); // посещенные вершины
            List<string> EulerTops = new List<string>();  // порядок вершин в Эйлеровом цикле

            int top1, top2;
            visited.Push(0);

            while (visited.Count != 0) 
            {
                top1 = visited.Peek();
                if (listsSmej[top1].Count != 0)
                {
                    top2 = listsSmej[top1][0];
                    visited.Push(top2);
                    listsSmej[top1].RemoveAt(0);
                    listsSmej[top2].Remove(top1);
                }
                else 
                {
                    EulerTops.Add(Convert.ToString(visited.Pop() + 1));   
                }   
            }

            labelAnswer.Visible = true;
            textBoxAnswer.Text = String.Join(" - ", EulerTops);
            textBoxAnswer.Visible = true;

            labelClear.Visible = true;
            buttonClear.Visible = true;
        }
    }
}
