﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Reader.Interfaces;

namespace CSV_to_JSON_converter.Reader
{
    internal class JSONReader : IReader
    {
        public string[] Read()
        {
            StringBuilder sb = new StringBuilder();
            string line;
            Console.WriteLine("It reads until End");
            while ((line = Console.ReadLine()) != "End")
            {
                sb.AppendLine(line);
            }
            string multiLineString = sb.ToString();
            string[] text = multiLineString.Split(new[]{
                "{",
                "}",
                "]",
                "[",
                "\"",
                ":",
                ",",
                "\r\n"

            }, StringSplitOptions.RemoveEmptyEntries);
            return text;
        }
    }
}
