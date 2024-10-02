using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaicevYaA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double pi = Math.PI;
            return Math.Round((Math.Cos(pi/x) / Math.Exp(x + y)) , 3);
        }
    }
}
