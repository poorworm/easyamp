using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAMP
{
    public class Host
    {
        public string host { get; set; }
        public string ip { get; set; }
    }

    public class ConfigObject
    {
        public string checkApacheUrl { get; set; }
        public string xamppPath { get; set; }
        public List<Host> hosts { get; set; }
    }
}
