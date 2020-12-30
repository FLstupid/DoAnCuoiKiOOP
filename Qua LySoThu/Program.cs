﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qua_LySoThu
{
   public class Program
    {
        public static List<PhongBan> Pb = new List<PhongBan>();
        public static List<ThucAn> dt = new List<ThucAn>();
        public static List<CongTyBanVe> ct = new List<CongTyBanVe>();
        public static List<NhanVien> nv = new List<NhanVien>();
        public static List<Ve> ve = new List<Ve>();
        public static List<KhachXem> kx = new List<KhachXem>();
        
        public static void TaoDSPhongBan()
        {
            Pb.Add(new PhongBan("PB1", "Phong CSKH", "Cua So Thu"));
            Pb.Add(new PhongBan("PB2", "Phong Ban Ve", "Cua So Thu"));
            Pb.Add(new PhongBan("PB3", "Phong Bao Ve", "Trung Tam So Thu"));
            Pb.Add(new PhongBan("PB4", "Phong Thuc An", "Phia Tay So Thu"));
            Pb.Add(new PhongBan("PB4", "Phong QLNV", "Phia Dong So Thu"));
        }
        public static void TaoDSThucAn()
        {
            dt.Add(new ThucAn("THIT01","THIT SONG"));
            dt.Add(new ThucAn("THITO2" , "THIT CHIN"));
            dt.Add(new ThucAn("THUCVAT01","CO"));
            dt.Add(new ThucAn("THUCVAT02", "TRAI CAY"));
        }
        public static void TaoDSCongTyBanVe()
        {
            ct.Add(new CongTyBanVe("CTY01", "Cong ty 01",1000,"1/1/2010"));
            ct.Add(new CongTyBanVe("CTY02", "Cong ty 02",1500,"15/1/2001"));

        }
        public static void TaoDSNhanVien()
        {
            nv.Add(new NhanVien("234345", "Nguyen Van A","PB1","Nhan Vien Ve Sinh"));
            nv.Add(new NhanVien("234456", "Tran Thi B","PB1", "Nhan Vien Cham Soc Thu An Thit"));
            nv.Add(new NhanVien("232325", "To Van C","PB2", "Nhan Vien Cham Soc Thu An Co"));
            nv.Add(new NhanVien("223456", "Cao Thi An","PB2", "Nhan Vien Ban Ve"));
            nv.Add(new NhanVien("256784", "Vo Van T","PB3", "Nhan Vien Bao Ve"));
            nv.Add(new NhanVien("232453", "Dinh Quoc K","PB3", "Nhan Vien Cham Khach Hang"));
            nv.Add(new NhanVien("232234", "Nguyen Minh L","PB4", "Nhan Vien Bao Ve"));
            nv.Add(new NhanVien("256234", "le Van An", "PB4", "Nhan Vien Ban Ve"));
        }
        public static void TaoDSVe()
        {
            ve.Add(new Ve("V1","Kh01", "234345", "1/1/2020"));
            ve.Add(new Ve("V2","Kh02", "234345", "2/1/2020"));
            ve.Add(new Ve("V3","Kh03", "234345", "5/1/2020"));
            ve.Add(new Ve("V4", "Kh04", "234345", "1/4/2020"));
            ve.Add(new Ve("V5", "Kh05", "234345", "14/1/2020"));
            ve.Add(new Ve("V6", "Kh06", "234345", "31/1/2020"));
            ve.Add(new Ve("V7", "Kh07", "234345", "1/4/2020"));
            ve.Add(new Ve("V8", "Kh08", "234345", "1/5/2020"));
        }
        public static void TaoDSKhachXem()
        {
            kx.Add(new KhachXem("Kh01","V1", "1/1/2020"));
            kx.Add(new KhachXem("Kh02","V2", "2/1/2020"));
            kx.Add(new KhachXem("Kh03","V3", "5/1/2020"));
            kx.Add(new KhachXem("Kh04","V4", "1/4/2020"));
            kx.Add(new KhachXem("Kh05","V5", "14/1/2020"));
            kx.Add(new KhachXem("Kh06","V6", "31/1/2020"));
            kx.Add(new KhachXem("Kh07","V7", "1/4/2020"));
            kx.Add(new KhachXem("Kh08","V8", "1/5/2020"));

        }
        static void Main(string[] args)
        {
            TaoDSCongTyBanVe();
            TaoDSKhachXem();
            TaoDSNhanVien();
            TaoDSPhongBan();
            TaoDSThucAn();
            TaoDSVe();

        }
    }
}
