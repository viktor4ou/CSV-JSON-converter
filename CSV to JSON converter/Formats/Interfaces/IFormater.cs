using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_JSON_converter.Formats.Interfaces
{
    public interface IFormater
    {   
        
        public string Format(string[] text);
    }
}
