﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_JSON_converter.Reader.Interfaces
{
    public interface IReader
    {
        public string []Read();
    }
}
