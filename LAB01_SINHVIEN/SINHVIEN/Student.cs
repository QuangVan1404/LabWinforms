using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        private string studentID; //mã số sinh viên
        private string fullName; // họ tên sinh viên
        private float averageScore; //điểm trung bình
        private string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public Student()
        {
        }
        // 4. Tao constuctor có tham số
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }
        public void Input()
        {
            Console.Write("Nhập MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();
            Console.Write("Nhập Điểm TB:");
            AverageScore = float.Parse(Console.ReadLine()); //ép sang kiểu float
            Console.Write("Nhập Khoa:");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ Tên:{1} Khoa:{2} ĐiêmTB:{3}", this.StudentID,
            this.fullName, this.Faculty, this.AverageScore);
        }
    }
}
