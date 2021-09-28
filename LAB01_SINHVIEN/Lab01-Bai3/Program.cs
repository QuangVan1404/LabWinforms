using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab01_3.Entities;
using System.Threading.Tasks;

namespace Lab01_3
{
    class Program
    {
        private static int Menu()
        {
            try
            {
                int choose;
                do
                {
                    Console.WriteLine("\t\t\tMenu");
                    Console.WriteLine("\t1 : Nhap ");
                    Console.WriteLine("\t2 : Xuat Danh Sach Khu Dat");
                    Console.WriteLine("\t3 : Xuất ra danh sách thông tin các khu đất có diện tích được sắp xếp tăng dần");
                    Console.WriteLine("\t4 : Xuất ra danh sách các khu đất có giá bán < x và diện tích >= y");
                    Console.WriteLine("\t5 : Tinh trung binh gia 1 m2 cua cac khu dat lon hon x m2");
                    Console.WriteLine("\t0 : Thoat");
                    Console.Write("Chon cong viec muon thuc hien : ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose < 0 || choose > 5);
                return choose;
            }
            catch (Exception)
            {
               throw;
            }
            finally
            {
                Console.WriteLine("Byeeee");
            }
        }

        private static List<KhuDat> TimDSKhuDat(List<KhuDat> DS, float x, float y)
        {
            return DS.Where(p => p.DienTich >= y && p.GiaBan < x).ToList();
        }

        private static void XuatDSKhuDat(List<KhuDat> dS1)
        {
            if (dS1.Count == 0)
            {
                Console.WriteLine("Danh sach Rong");
            }
            else
            {
                Console.WriteLine("\nDanh sach : ");
                foreach (var item in dS1)
                {
                    item.Xuat();
                }
            }
        }

        private static void NhapDSKhuDat(List<KhuDat> dS1)
        {
            KhuDat temp;
            string key = "";

            do
            {
                Console.Clear();
                temp = new KhuDat();
                temp.Nhap();
                dS1.Add(temp);
                Console.WriteLine("De tiep tuc nhap nhan phim 1 ");
                key = (Console.ReadLine());
            } while (key == "1");
        }

        public static List<KhuDat> DSKhuDatGiaVaDienTich(DSKhuDat DS, float DienTich, float GiaBan)
        {
            return DS.ds.Where(p => p.DienTich >= DienTich && p.GiaBan < GiaBan).ToList();
        }
        public static float GiaTBKhuDat(float dienTich, DSKhuDat DS)
        {
            float SumDT = 0, SumGia = 0;
            List<KhuDat> DSKhuDatCanTinh = DS.ds.Where(p => p.DienTich > dienTich).ToList();
            if (DSKhuDatCanTinh.Count == 0)
            {
                return 0;
            }
            foreach (KhuDat khuDat in DSKhuDatCanTinh)
            {
                SumDT += khuDat.DienTich;
                SumGia += khuDat.GiaBan;

            }
            return SumGia / SumDT;
        }
        public static List<KhuDat> SapXep(List<KhuDat> DS1)
        {
            return DS1.OrderBy(p => p.DienTich).ToList();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DSKhuDat dSKhuDat = new DSKhuDat();
            int choose;
            do
            {
                Console.Clear();
                choose = Menu();
                switch (choose)
                {
                    case 1:
                        NhapDSKhuDat(dSKhuDat.ds);
                        break;
                    case 2:
                        XuatDSKhuDat(dSKhuDat.ds);
                        break;
                    case 3:
                        XuatDSKhuDat(SapXep(dSKhuDat.ds));
                        break;
                    case 4:
                        float x, y;
                        Console.Write("Nhap x = ");
                        x = float.Parse(Console.ReadLine());
                        Console.Write("Nhap y = ");
                        y = float.Parse(Console.ReadLine());
                        XuatDSKhuDat(TimDSKhuDat(dSKhuDat.ds, x, y));
                        break;
                    case 5:
                        Console.Write("Nhap dien tich muon tinh don gia trung binh 1m2 : ");
                        float dienTich = float.Parse(Console.ReadLine());
                        Console.WriteLine("Gia Trung binh 1m2  cua cac khu dat lon hon {0} m2 là: {1}", dienTich, GiaTBKhuDat(dienTich, dSKhuDat));
                        break;
                    default:
                        break;
                }
                Console.Write("Nhan phim bat ky de tiep tuc ... ");
                Console.ReadKey();
            } while (choose != 0);
        }
            
    }
}
