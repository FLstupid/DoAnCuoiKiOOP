using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
    public class NhanVien
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string mapb { get; set; }
        public string chucvu { get; set; }
        public NhanVien(string manv,string tennv, string mapb,string chucvu)
        {
            this.mapb = mapb;
            this.manv = manv;
            this.tennv = tennv;
            this.chucvu = chucvu;
        }
        public NhanVien(NhanVien nv)
        {
            this.mapb = nv.mapb;
            this.manv = nv.manv;
            this.tennv = nv.tennv;
            this.chucvu = nv.chucvu;
        }
    }
}
