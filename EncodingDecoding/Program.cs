using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingDecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data =new List<string>() { "@P", "AQ", "BR", "CS", "DT", "EU", "FV", "GW", "HX", "IY", "JZ", "K[", "L'\'", "M]", "N^", "O_"};
            string input = "saya_mau_Makan";
            string encode = "";
            string output ="";
            char[] cInput = input.ToCharArray();
            foreach (char i in cInput)
            {
                string value = i.ToString().ToUpper();
                List<string> nilai = data.FindAll(x => x.Contains(value));
                foreach(string a in nilai)
                {
                    int index = a.IndexOf(value);
                    encode=a.Remove(index,1);
                    output += encode;
                }                
            }
            Console.WriteLine("output {0}", output);
            Console.ReadKey();
        }
    }
}
