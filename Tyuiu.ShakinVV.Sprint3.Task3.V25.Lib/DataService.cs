using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShakinVV.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            string str = "kjhgfuu gujut dtuu";
            int count = 0;
            int min = int.MaxValue;
            foreach (char chr in str)
            {
                if (chr == item)
                {
                    count++;
                }
                else
                {
                    if (count > 0 && count < min)
                    {
                        min = count;
                    }
                    count = 0;
                }
                if (count > 0 && count < min)
                {
                    min = count;
                }
            }
            return (min);
        }
    }
}

