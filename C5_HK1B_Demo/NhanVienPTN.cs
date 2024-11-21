using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class NhanVienPTN : NhanVien
    {
        public double LuongThang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong thang: ");
            LuongThang = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong: " + TinhLuong());
        }

        public override double TinhLuong()
        {
            return LuongThang;
        }
    }
}
