using System;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    class Program
    {   
        static void Main(string[] args)
        {
            var text = "Takis";
            Console.WriteLine(ReverseAndCapitalizeText(text));
        }
        public static string ReverseAndCapitalizeText(string text)
        {
            var builder = new StringBuilder(string.Join("", text.Reverse()));

            builder[0] = Char.ToUpper(builder[0]);

            builder[builder.Length - 1] = Char.ToLower(builder[builder.Length - 1]);

            return builder.ToString();
        }
    }
}
