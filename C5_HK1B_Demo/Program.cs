using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VienKhoaHoc vienKhoaHoc = new VienKhoaHoc();

            while (true)
            {
                Console.WriteLine("1. Nhap nhan vien");
                Console.WriteLine("2. Xuat nhan vien");
                Console.WriteLine("3. Xuat luong nhan vien");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        vienKhoaHoc.Nhap();
                        break;
                    case 2:
                        vienKhoaHoc.Xuat();
                        break;
                    case 3:
                        vienKhoaHoc.XuatLuong();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
