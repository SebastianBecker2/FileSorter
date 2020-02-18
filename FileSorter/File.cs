using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter
{
    class File
    {
        public string  FilePath { get; set; }
        public string FileName { get; set; }
        public string DestinationFolderPath { get; set; }
        public string  FilterKey { get; set; }
        public bool Sort { get; set; }
    }
}
