using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qua_LySoThu
{
    public class CongTyBanVe
    {
       public string macty { get; set; }
        public string tencty { get; set; }
        public int soluongvemua { get; set; }
        public string ngaymua {get;set; }

        public CongTyBanVe(string macty, string tencty,int soluongvemua,string ngaymua)
        {
            this.macty = macty;
            this.tencty = tencty;
            this.soluongvemua = soluongvemua;
            this.ngaymua = ngaymua;
        }
        public CongTyBanVe(CongTyBanVe cty)
        {
            this.macty = cty.macty;
            this.tencty = cty.tencty;
            this.soluongvemua = cty.soluongvemua;
            this.ngaymua = cty.ngaymua;
        }
    }
}
