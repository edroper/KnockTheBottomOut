using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using CommandLine.Text; 

namespace KnockTheBottomOut
{
    class Options
    {
        [Option('i', "input-path", Required = true, HelpText = "Input file path")]
        public string path { get; set; }

        [Option('o', "outpath", Required = true, HelpText = "Output file path")]
        public string path { get; set; }

    }
}
