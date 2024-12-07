using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AidemirAF.Sprint6.Task2.V19.Lib
{
    public class DataService : ISprint6Task2V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] array = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
                if (x != -1.7)
                {
                    array[count] = Math.Round(Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6, 2);
                    count++;
                }
                else
                {
                    array[count] = 0;
                    count++;
                }
            return array;
        }
    }
}
