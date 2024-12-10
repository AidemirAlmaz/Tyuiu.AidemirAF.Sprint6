using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AidemirAF.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    string[] words = line.Split(' ');
                    if (words.Length > 3)
                    {
                        resStr += words[3] + ' ';
                    }
                }
            }
            return resStr;
        }
    }
}
