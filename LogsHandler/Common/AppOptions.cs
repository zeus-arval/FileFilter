using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsHandler.Common
{
    public class AppOptions
    {
        public readonly string[] FILE_EXTENSIONS = new string[]
        {
            ".txt",
            ".log"
        };

        public string FilePath { get; set; }
    }
}
