using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class VienKhoaHoc
    {
        List<NhanVien> dsNhanVien = new List<NhanVien>();

        public void Nhap()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu " + (i + 1));
                Console.Write("Nhap loai nhan vien (1: Nhan vien phong thi nghiem, 2: Nha khoa hoc, 3: Nha quan ly): ");
                int loai = int.Parse(Console.ReadLine());
                NhanVien nv;
                if (loai == 1)
                {
                    nv = new NhanVienPTN();
                }
                else if (loai == 2)
                {
                    nv = new NhaKhoaHoc();
                }
                else
                {
                    nv = new NhaQuanLy();
                }
                nv.Nhap();
                dsNhanVien.Add(nv);
            }
        }

        public void Xuat()
        {
            foreach (NhanVien nv in dsNhanVien)
            {
                nv.Xuat();
            }
        }

        // Xuất lương của từng loại nhân viên trong viện khoa học
        public void XuatLuong()
        {
            //xuất lương của toàn bộ nhân viên phòng thi nghiệm trong viện khoa học
            double tongLuongPTN = 0;
            double tongLuongNKH = 0;
            double tongLuongNQL = 0;
            foreach (NhanVien nv in dsNhanVien)
            {
                if (nv is NhanVienPTN)
                {
                    tongLuongPTN += nv.TinhLuong();
                }
                else if (nv is NhaKhoaHoc)
                {
                    tongLuongNKH += nv.TinhLuong();
                }
                else { 
                    tongLuongNQL += nv.TinhLuong(); 
                }
            }
            Console.WriteLine("Tong luong nhan vien phong thi nghiem: " + tongLuongPTN);
            Console.WriteLine("Tong luong nha khoa hoc: " + tongLuongNKH);
            Console.WriteLine("Tong luong nha quan ly: " + tongLuongNQL);
        }
    }
}
