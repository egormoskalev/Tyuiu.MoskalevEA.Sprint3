using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevEA.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    value = value.Replace(c,item);
                }
            }
            return value;
        }
    }
}
