using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Formats.Interfaces;

namespace CSV_to_JSON_converter.Formats
{
    public class JSONFormat : IFormater
    {
        private string format => "\"{0}\"";

        public string Format(string[] text)
        {
            StringBuilder sb = new StringBuilder();
            string firstColumn = text[0]; // this should be dynamic
            string secondColumn = text[1];

            for (int i = 2; i < text.Length - 1; i += 2)
            {
                sb.Append("{");
                sb.Append($"\"{firstColumn}\":{String.Format(format, text[i])},\"{secondColumn}\":" +
                          $"{String.Format(format, text[i + 1])}");
                sb.Append("}");
                if (i < text.Length - 2)
                {
                    sb.AppendLine(",");
                }
            }
            Console.Clear();
            Console.WriteLine("Converted as JSON:");
            return "[" + sb.ToString() + "]";
        }
    }
}
