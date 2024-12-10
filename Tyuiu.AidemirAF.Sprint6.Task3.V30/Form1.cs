using Tyuiu.AidemirAF.Sprint6.Task3.V30.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task3.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { { -9, -4, 17, -1, -20 },
                        { -19, 18, -4, 2, 14 },
                        { -12, 16, -2, 7, 18 },
                        { -16, 15, 4, -12, -13 },
                        { -15, -4, -16, 1, -14} };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewMtrx.ColumnCount = columns;
            dataGridViewMtrx.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewMtrx.ColumnCount = columns;
            dataGridViewMtrx.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-24-1 Айдемир Алмаз Фуатович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
