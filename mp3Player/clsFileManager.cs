using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp3Player
{
    public class clsFileManager
    {
        public string SourceDirectory { get; set; }
        public List<string> MediaFiles { get; set; }

        public clsFileManager()
        {
            MediaFiles = new List<string>();
        }

    }
}
