using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgovIV.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string res = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (i == 0 || (value[i] == ' ' && i != value.Length && value[i-1]!= ' '))
                {
                    res += "";
                }
                else if (i != value.Length)
                {
                    res += value[i-1];
                }

                if (i == value.Length && value[i] == ' ')
                {
                    res += ' ';
                }
            }
            return res;
        }
    }
}
