using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ЗАДАНИЕ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово ");
            string str = Console.ReadLine();
            StringBuilder strb = new StringBuilder(str);

            strb[0] = str[str.Length - 1];
            strb[str.Length - 1] = str[0];
            return strb.ToString();
        }
    }
}
