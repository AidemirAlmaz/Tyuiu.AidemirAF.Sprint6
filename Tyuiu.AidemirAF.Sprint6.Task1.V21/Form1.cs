using Tyuiu.AidemirAF.Sprint6.Task1.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint6.Task1.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button_Done_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox_StartStep.Text);
                int stopStep = Convert.ToInt32(textBox_StopStep.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBox_Result.Text = "";
                textBox_Result.AppendText("+-----------+------------+" + Environment.NewLine);
                textBox_Result.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBox_Result.AppendText("+-----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|  {0,5:d}    |   {1, 6:f2}   |", startStep, valueArray[i]);
                    textBox_Result.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBox_Result.AppendText("+-----------+------------+" + Environment.NewLine); 
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
