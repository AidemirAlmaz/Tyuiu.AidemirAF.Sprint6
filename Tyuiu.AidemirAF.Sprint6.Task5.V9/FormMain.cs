using Tyuiu.AidemirAF.Sprint6.Task5.V9.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";

        private void buttonDone_AAF_Click(object sender, EventArgs e)
        {
            dataGridViewResult_AAF.ColumnCount = 2;
            dataGridViewResult_AAF.Columns[0].Width = 50;
            dataGridViewResult_AAF.Columns[1].Width = 50;
            this.chartFunction_AAF.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_AAF.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_AAF.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_AAF.Rows.Add(Convert.ToString(numsMass[i]));
                chartFunction_AAF.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonOpen_AAF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_AAF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-24-1 Айдемир Алмаз Фуатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
