using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_3.Entities;
namespace Lab01_3
{
    class DSKhuDat
    {
        protected   List<KhuDat> DS ;

        public List<KhuDat> ds { get => DS; set => DS = value; }

        public DSKhuDat()
        {
            ds = new List<KhuDat>();
        }

       
        public void Them (KhuDat khuDat)
        {
            ds.Add(khuDat);
        }
       
        public void Xuat()
        {
            if (ds == null) {
                Console.WriteLine("Danh Sach Khu Dat Dang Trong");
                return;
            }

            foreach (KhuDat khuDat in ds)
            {
                khuDat.Xuat();
            }
        }
      
        
    }
}
