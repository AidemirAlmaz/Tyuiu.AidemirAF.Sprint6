using Tyuiu.AidemirAF.Sprint6.Task6.V30.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpen_AAF_Click_1(object sender, EventArgs e)
        {
            openFileDialogTask_AAF.ShowDialog();
            openFilePath = openFileDialogTask_AAF.FileName;
            textBoxInPut_AAF.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_AAF.Text = groupBoxOutPut_AAF + " " + openFileDialogTask_AAF.FileName;
            buttonDone_AAF.Enabled = true;
        }

        private void buttonDone_AAF_Click(object sender, EventArgs e)
        {
            textBoxResult_AAF.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_AAF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
