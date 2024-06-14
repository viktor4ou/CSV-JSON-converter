using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using CSV_to_JSON_converter.Converters;
using CSV_to_JSON_converter.Formats;
using CSV_to_JSON_converter.Formats.Interfaces;
using CSV_to_JSON_converter.Reader;
using CSV_to_JSON_converter.Reader.Interfaces;
using StringReader = CSV_to_JSON_converter.Reader.StringReader;

namespace CSV_to_JSON_converter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.WriteLine("What is going to be the input type (CSV,JSON, String-> supports only JSON format)");
            string inputType = Console.ReadLine().ToLower();
            Console.WriteLine("To what do you want to convert the input (CSV,JSON,String):");
            string convertType;
            convertType = Console.ReadLine().ToLower();
            if (inputType == "json" && convertType == "csv")
            {
                IReader reader = new JSONReader();
                string[] text = reader.Read();
                IFormater formater = new CSVFormat();
                Console.WriteLine(converter.ConvertTo(formater, text));

            }
            else if (inputType == "json" && convertType == "string")
            {
                IReader reader = new JSONReader();
                string[] text = reader.Read();
                IFormater formater = new StringFormat();
                Console.WriteLine(converter.ConvertTo(formater, text));
            }
            else if (inputType == "csv" && convertType == "json")
            {

                IReader reader = new CSVReader();
                string[] text = reader.Read();
                IFormater formatter = new JSONFormat();
                Console.WriteLine(converter.ConvertTo(formatter, text));
            }
            else if (inputType == "csv" && convertType == "string")
            {
                IReader reader = new CSVReader();
                string[] text = reader.Read();
                IFormater formater = new StringFormat();
                Console.WriteLine(converter.ConvertTo(formater, text));
            }
            else if (inputType == "string" && convertType == "json")
            {
                IReader reader = new StringReader();
                string[] text = reader.Read();
                IFormater formatter = new JSONFormat();
                Console.WriteLine(converter.ConvertTo(formatter, text));
            }
            else if (inputType == "string" && convertType == "csv")
            {
                IReader reader = new StringReader();
                string[] text = reader.Read();
                IFormater formatter = new CSVFormat();
                Console.WriteLine(converter.ConvertTo(formatter, text));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
