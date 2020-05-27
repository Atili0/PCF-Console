using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCF_CONSOLE
{
    public interface IPcfObject
    {
        string sName { get; set; }
        string sNamespace { get; set; }
        string sTemplate { get; set; }
        string sFolder { get; set; }
    }

    public class PcfObject : IPcfObject
    {
        public string sNamespace { get; set; }
        public string sName { get; set; }
        public string sTemplate { get; set; }
        public string  sFolder { get; set; }
    }


}
