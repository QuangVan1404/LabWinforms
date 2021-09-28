using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static List<Student> listStudent = new List<Student>();
        private static List<Student> NhapDSSinhVien()
        {
            Console.Write("Nhập tổng số sinh viên N =");
            int N = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n ====Nhập Danh Sách sinh viên====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhập sinh viên thứ {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listStudent.Add(temp);
            }
            return listStudent;
        }

        private static void XuatDSSinhVien()
        {
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên====");
            foreach (Student sv in listStudent)
            {
                sv.Show();
            }
            Console.ReadKey();
        }

        private static void XuatDSSinhVienCNTT()
        {
            List<Student> listStudentCNTT = (from s in listStudent where s.Faculty == "CNTT" select s).ToList();
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên CNTT====");
            foreach (Student sv in listStudentCNTT)
            {
                sv.Show();
            }
            Console.ReadKey();
       
        }

        private static void XuatDSSinhVienDTBLonHon5()
        {
            List<Student> listStudentDTBLon5 = (from s in listStudent where s.AverageScore >= 5 select s).ToList();
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên DTB > 5====");
            foreach (Student sv in listStudentDTBLon5)
            {
                sv.Show();
            }
            Console.ReadKey();
     
        }

        private static void XuatDSSinhVienDTBTangDan()
        {
            List<Student> listStudentDTBTangDan = listStudent.OrderBy(p => p.AverageScore).ToList();
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên DTB tang dan====");
            foreach (Student sv in listStudentDTBTangDan)
            {
                sv.Show();
            }
            Console.ReadKey();
        }

        private static void XuatDSSinhVienCNTTDTBLonHon5()
        {
            List<Student> listStudentCNTTDTBLonHon5 = (from s in listStudent where s.AverageScore >= 5 && s.Faculty=="CNTT" select s).ToList();
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên CNTT DTB > 5====");
           foreach(Student sv in listStudentCNTTDTBLonHon5)
            {
                sv.Show();
            }
            Console.ReadKey();
        }

        private static void XuatDSSinhVienCNTTDTBCaoNhat()
        {
            
            List<Student> listStudentCNTTDTBLonHon5 = (from s in listStudent where s.AverageScore >= 5 && s.Faculty == "CNTT" select s).ToList();
            var result = listStudentCNTTDTBLonHon5.OrderByDescending(x => x.AverageScore).First();
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên CNTT==== ");
            result.Show();


            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Để sử dụng tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            listStudent = NhapDSSinhVien();

            XuatDSSinhVien();
            XuatDSSinhVienCNTT();

            XuatDSSinhVienDTBLonHon5();
            XuatDSSinhVienDTBTangDan();
            XuatDSSinhVienCNTTDTBLonHon5();
            XuatDSSinhVienCNTTDTBCaoNhat();

        }

        
    }
}
