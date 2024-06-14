using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Coverters.Interfaces;
using CSV_to_JSON_converter.Formats.Interfaces;
using CSV_to_JSON_converter.Reader.Interfaces;

namespace CSV_to_JSON_converter.Converters
{
    public class Converter : IConverter
    {
        public string ConvertTo(IFormater format, string [] text)
        {
             
            return format.Format(text);
        }
    }

        
    
}
