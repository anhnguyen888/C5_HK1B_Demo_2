using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            BangCap = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Bang cap: " + BangCap);
        }

        public abstract double TinhLuong();
    }
}
