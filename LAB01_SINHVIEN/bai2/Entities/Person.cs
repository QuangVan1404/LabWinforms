using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_2.Entities
{
    class Person
    {
        private string id; //mã số sinh viên
        private string fullName;

        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Person() { }

        public Person(string id, string fullName)
        {
            this.fullName = fullName;
            this.id = id;
        }

        public static void Input()
        {
            Console.Write("Ho Ten: ");
            fullName = Console.ReadLine();
          
            Console.Write("Ma So: ");
            id = Console.ReadLine();
        }

        public static void Output()
        {
            Console.Write("Họ Tên:{0}  \tMa So:{1}", fullName, id);
           
        }
    }
}
