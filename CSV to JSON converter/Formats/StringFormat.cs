using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Formats.Interfaces;

namespace CSV_to_JSON_converter.Formats
{
    internal class StringFormat : IFormater
    {
        public string Format(string[] text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i] );
                if (i < text.Length - 1)
                {
                    sb.Append(",");
                }
                
            }
            Console.Clear();
            Console.WriteLine("Converted as String:");
            return sb.ToString();
        }
    }
}
