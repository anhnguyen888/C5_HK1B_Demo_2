using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class NhaQuanLy : NhanVien
    {
        public int SoNgayCong { get; set; }
        public float BacLuong { get; set; }
        public string ChucVu { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac luong: ");
            BacLuong = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Bac luong: " + BacLuong);
            Console.WriteLine("So ngay cong: " + SoNgayCong);
            Console.WriteLine("Chuc vu: " + ChucVu);
        }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
