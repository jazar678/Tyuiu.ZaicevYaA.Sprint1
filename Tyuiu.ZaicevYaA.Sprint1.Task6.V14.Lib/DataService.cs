using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaicevYaA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            value = value.Replace(" ","");
            value = value.Replace("*", "");
            return value;
        }
    }
}
