using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Reader.Interfaces;

namespace CSV_to_JSON_converter.Reader
{
    internal class StringReader : IReader
    {
        public string[] Read()
        {
            Console.WriteLine("Enter your input:");
            return Console.ReadLine().Split(',');

        }
    }
}
