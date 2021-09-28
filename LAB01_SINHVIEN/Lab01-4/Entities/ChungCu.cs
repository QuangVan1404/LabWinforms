using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_4.Entities
{
    class ChungCu : KhuDat
    {
        private int tang;
        public int Tang { get => tang; set => tang = value; }
        public ChungCu() : base() { }

        public ChungCu(string diaChi, float giaBan, float dienTich, int tang) : base(diaChi, dienTich, giaBan)
        {

            this.tang = Tang;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine();
            Console.Write("Nhap tang chung cu : ");
            Tang = int.Parse(Console.ReadLine());
            
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Tang : {0}", this.Tang);
        }

    }
}
