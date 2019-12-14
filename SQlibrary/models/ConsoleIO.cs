using SQlibrary.interfaces;
using System;

namespace SQlibrary.models
{
    public class ConsoleIO : iIOmethod
    {
        public int getIntData()
        {
            string text = Console.ReadLine();
            int result;
            if (Int32.TryParse(text, out result))
                return result;
            else
                return 0;
        }

        public void showData(string text)
        {
            Console.WriteLine(text);
        }
    }
}
