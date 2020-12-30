using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
    public class ThucAn
    {
        public string mathucan { get; set;}
        public string tenthucan { get; set; }
        public ThucAn(string mathucan, string tenthucan)
        {
            this.mathucan = mathucan;
            this.tenthucan = tenthucan;
        }
        public ThucAn(ThucAn a)
        {
            this.mathucan = a.mathucan;
            this.tenthucan = a.tenthucan;
        }
    }
}
