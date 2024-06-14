using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Reader.Interfaces;

namespace CSV_to_JSON_converter.Reader
{
    internal class CSVReader : IReader

    {
        public string[] Read()
        {
            string line;
            Console.WriteLine("It reads until End");
            Console.WriteLine("Please enter the Input:");
            StringBuilder sb = new StringBuilder();
            while ((line = Console.ReadLine()) != "End")
            {
                sb.AppendLine(line);
            }
            string multiLineString = sb.ToString();
            string[] text = multiLineString.Split(new[]{
                "\r\n",
                "\"",
                ","


            }, StringSplitOptions.RemoveEmptyEntries);

            return text;
        }
    }
}
