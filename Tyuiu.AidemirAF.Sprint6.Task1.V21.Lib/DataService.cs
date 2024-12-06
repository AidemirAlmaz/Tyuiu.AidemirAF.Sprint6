using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AidemirAF.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] array = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
                if (x != 1)
                {
                    array[count] = Math.Round(Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x, 2);
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
