using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class NhaKhoaHoc : NhaQuanLy
    {
        public int SoBaiBao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so bai bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So Bai bao: " + SoBaiBao);
        }
    }
}
