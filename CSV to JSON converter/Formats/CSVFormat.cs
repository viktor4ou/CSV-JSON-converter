using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Formats.Interfaces;

namespace CSV_to_JSON_converter.Formats
{
    public class CSVFormat : IFormater
    {
        private string format => "\"{0}\"";

        public string Format(string[] text)
        {
            StringBuilder sb = new StringBuilder();
            string firstColumn = text[0];
            string secondColumn = text[2];
            sb.AppendLine($"\"{firstColumn}\",\"{secondColumn}\"");
            for (int i = 1; i < text.Length - 2; i+=4)
            {
                string currentString = text[i];
                if (currentString != firstColumn || currentString != secondColumn)
                {
                    sb.AppendLine($"\"{currentString}\",\"{text[i + 2]}\"");
                }
            }
            Console.Clear();
            Console.WriteLine("Converted as CSV:");
            return sb.ToString();
        }
    }
}
