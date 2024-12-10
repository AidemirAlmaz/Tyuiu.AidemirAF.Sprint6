using Tyuiu.AidemirAF.Sprint6.Task4.V24.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_AAF_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_AAF.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_AAF.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_AAF.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAF.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_AAF.Text = "";
                chartFunction_AAF.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_AAF.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_AAF.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V24.txt";
                File.WriteAllText(path, textBoxResult_AAF.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранен!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранение файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAF_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-24-1 Айдемир Алмаз Фуатович", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
