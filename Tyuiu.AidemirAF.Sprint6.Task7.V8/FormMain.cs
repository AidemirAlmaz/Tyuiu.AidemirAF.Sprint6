using Tyuiu.AidemirAF.Sprint6.Task7.V8.Lib;

namespace Tyuiu.AidemirAF.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_AAF.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMtrx_AAF.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        int rows;
        int columns;
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_AAF_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAF.ShowDialog();
            openFilePath = openFileDialogTask_AAF.FileName;

            string filedata = File.ReadAllText(openFilePath);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            dataGridViewIn_AAF.ColumnCount = columns;
            dataGridViewIn_AAF.RowCount = rows;
            dataGridViewOut_AAF.ColumnCount = columns;
            dataGridViewOut_AAF.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_AAF.Columns[i].Width = 35;
                dataGridViewOut_AAF.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_AAF.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonResult_AAF.Enabled = true;
        }
        private void buttonResult_AAF_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_AAF.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSave_AAF.Enabled = true;
        }
        private void buttonSave_AAF_Click(object sender, EventArgs e)
        {
            saveFileDialogMtrx_AAF.FileName = "OutPutFileTask7.csv";
            saveFileDialogMtrx_AAF.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMtrx_AAF.ShowDialog();

            string path = saveFileDialogMtrx_AAF.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_AAF.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_AAF.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonHelp_AAF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
