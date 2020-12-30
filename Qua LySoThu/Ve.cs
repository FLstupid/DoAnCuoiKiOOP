using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
    public class Ve
    {
        public string mave { get; set; }
        public string makhach { get; set; }
        public string maNVbanve { get; set; }
        public string ngayban { get; set; }
        public Ve(string mave, string makhach, string maNVbanve, string ngayban)
        {
            this.mave = mave;
            this.makhach = makhach;
            this.maNVbanve = maNVbanve;
            this.ngayban = ngayban;
        }
        public Ve(Ve v)
        {
            this.maNVbanve = v.maNVbanve;
            this.mave = v.mave;
            this.makhach = v.makhach;
            this.ngayban = v.ngayban;
        }
    }
}
