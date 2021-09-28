using Lab01_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_2.Entities
{
    class Student : Person
    {
        private float averageScore; 
        private string faculty;
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public Student()
        {
        }
      
        public Student(string id, string name, float score, string faculty): base(id, name)
        {
            AverageScore = score;
            Faculty = faculty;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập Điểm TB:");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Nhập Khoa:");
            Faculty = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\tKhoa:{0}\tĐiêmTB:{1}\n",  this.Faculty, this.AverageScore);
        }
    }
}
