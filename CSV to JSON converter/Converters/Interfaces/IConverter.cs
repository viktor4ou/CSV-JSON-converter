using CSV_to_JSON_converter.Formats.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_to_JSON_converter.Reader.Interfaces;

namespace CSV_to_JSON_converter.Coverters.Interfaces
{
    public interface IConverter
    {
        string ConvertTo(IFormater format,string [] text);
    }
}
