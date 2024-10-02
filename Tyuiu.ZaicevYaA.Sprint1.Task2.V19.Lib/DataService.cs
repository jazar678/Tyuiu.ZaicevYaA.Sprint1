using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaicevYaA.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {
            return Math.Round(0.0254 * value, 3);
        }
    }
}
