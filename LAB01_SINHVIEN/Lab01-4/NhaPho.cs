using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_4.Entities
{
    class NhaPho : KhuDat
    {
        private int namXayDung;
        private int soTang;

        public int NamXayDung { get => namXayDung; set => namXayDung = value; }
        public int SoTang { get => soTang; set => soTang = value; }
        public override int getNamXayDung()
        { 
            return this.NamXayDung;
        }

        public NhaPho() : base() 
        {
            
        }

        public NhaPho(string diaChi, float giaBan, float dienTich, int namXayDung, int soTang) : base(diaChi, dienTich, giaBan)
        {
            this.namXayDung = NamXayDung;
            this.soTang = SoTang;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine();
            Console.Write("Nhap nam xay dung : ");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang nha pho : ");
            SoTang = int.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Nam xay dung:{0}\tSo tang:{1}", this.NamXayDung, this.SoTang) ;
        }
    }
}
