using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
    public class PhongBan
    {
        public string mapb { get; set; }
        public string tenpb { get; set; }
        public string diadiem { get; set; }
        public PhongBan(string mapb, string tenpb, string diadiem)
        {
            this.mapb = mapb;
            this.tenpb = tenpb;
            this.diadiem = diadiem;
        }
        public PhongBan(PhongBan dd)
        {
            this.mapb = dd.mapb;
            this.tenpb = dd.tenpb;
            this.diadiem = dd.diadiem;
        }
    }
}
