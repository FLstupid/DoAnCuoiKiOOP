using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
    public class KhachXem
    {
        public string makhach { get; set; }
        public string mave { get; set; }
        public string Ngayvaoxem { get; set; }

        public KhachXem(string makhach, string mave, string ngayvaoxem)
        {
            this.makhach = makhach;
            this.mave = mave;
            this.Ngayvaoxem = ngayvaoxem;
        }
        public KhachXem(KhachXem kx)
        {
            this.makhach = kx.makhach;
            this.mave = kx.mave;
            this.Ngayvaoxem = kx.Ngayvaoxem;
        }
    }
}
