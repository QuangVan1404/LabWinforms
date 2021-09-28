using Lab01_4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_4
{
    class Program
    {
        static KhuDat khuDat;
        static List<KhuDat> listKhuDat = new List<KhuDat>();
        public static void XuatDS()
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Output();
            }
        }
        public static void tong3Loai()
        {
            float SumGia = 0;
           
            foreach (KhuDat khuDat in listKhuDat)
            {
                SumGia += khuDat.GiaBan;
            }
            Console.WriteLine("Gia tien tong danh sach 3 loai la: {0}", SumGia);
        }
        public static void XuatDSTheoDk()
        {
            // Xuất danh sách các khu đất có diện tích > 100m2
            // hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2020
            Console.WriteLine("\n ====Xuất danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2020====");
        
            foreach (KhuDat kd in listKhuDat)
            {
                if (kd.GetType().ToString() == "Lab01_4.Entities.KhuDat" && kd.DienTich > 100) kd.Output();
                if (kd.GetType().ToString() == "Lab01_4.Entities.NhaPho" && kd.DienTich > 60 && kd.getNamXayDung() >= 2020) kd.Output();
            }
        }

        private static bool KiemTra (KhuDat kd, string diaChiCanTiem, float giaBanCanTiem, float dienTichCanTiem)
        { 
            if (kd.DiaChi.Contains(diaChiCanTiem) && kd.GiaBan <= giaBanCanTiem && kd.DienTich >= dienTichCanTiem) 
                return true;
            return false;
        } 
        private static void TimKiem()
        {

            /* Nhập vào các thông tin cần tìm kiếm(địa điểm, giá, diện tích). Xuất thông tin danh sách tất
               cả các nhà phố hoặc chung cư phù hợp yêu cầu.(có địa điểm chứa chuỗi tìm kiếm không
               phân biệt hoa thường, có giá <= giá tìm kiếm, và diện tích >= diện tích cần tìm kiếm)*/
            string diaChi;
            float giaBan, dienTich;
            Console.Write("Nhap dia chi khu dat can tim: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap gia can tim : ");
            giaBan = float.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich can tim: ");
            dienTich = float.Parse(Console.ReadLine());

            foreach (KhuDat kd in listKhuDat)
            {
                if (KiemTra(kd, diaChi, giaBan, dienTich)) kd.Output();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
               
                Console.WriteLine("\t1. Nhập khu dat");
                Console.WriteLine("\t2. Nhập nha pho");
                Console.WriteLine("\t3. Xuat chung cu");
                Console.WriteLine("\t4. Xuat DS");
                Console.WriteLine("\t5. Xuat tong gia 3 loai");
                Console.WriteLine("\t6. Xuất danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2020");
                Console.WriteLine("\t7. Xuất thông tin danh sách tất cả các nhà phố hoặc chung cư phù hợp yêu cầu.(");
                Console.WriteLine("\t0. END");
                Console.WriteLine("---MENU---");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        khuDat = new KhuDat();
                        khuDat.Input();
                        listKhuDat.Add(khuDat);
                        break;
                    case 2:
                        khuDat = new NhaPho();
                        khuDat.Input();
                        listKhuDat.Add(khuDat);
                        break;
                    case 3:
                        khuDat = new ChungCu();
                        khuDat.Input();
                        listKhuDat.Add(khuDat);
                        break;
                    case 4:
                        XuatDS();
                        break;
                    case 5:
                        tong3Loai();
                        break;
                    case 6:
                        XuatDSTheoDk();
                        break;
                    case 7:
                        TimKiem();
                        break;
                    
                    default:
                        return;

                }
                
            } while (true);
        }
    }
}
