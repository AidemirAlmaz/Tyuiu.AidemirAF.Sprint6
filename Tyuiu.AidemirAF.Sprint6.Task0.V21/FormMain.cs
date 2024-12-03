using Tyuiu.AidemirAF.Sprint6.Task0.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResults.Text = Convert.ToString(ds.Calculate(2));
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
