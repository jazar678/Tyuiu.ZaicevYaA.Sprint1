using System.Net.Security;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaicevYaA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            Regex regex = new Regex(@"^[а-яё]+$");
            return regex.IsMatch(value);
        }
    }
}
