using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLauncher
{
    public class ProgramItem
    {
        public string name { get; set; }
        public string path { get; set; }

        public ProgramItem(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

    }
}
