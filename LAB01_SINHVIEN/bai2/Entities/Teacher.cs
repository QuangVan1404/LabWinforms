using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_2.Entities
{
    class Teacher : Person
    {
        private string diaChi;

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public Teacher() { }

        public Teacher( string id, string fullName, string diaChi) : base(id, fullName)
        {
            DiaChi = diaChi;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Dia chi:");
            DiaChi = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.Write("\tDia chi:{0}\n1", this.DiaChi);
        }
    }

}
