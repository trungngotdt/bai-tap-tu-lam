using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptulam
{
    class Thucphamdh:Bai2_thucpham
    {
        private int sohop;

        public int Sohop
        {
            get
            {
                return sohop;
            }

            set
            {
                sohop = value;
            }
        }
        public Thucphamdh()
        {
            Sohop = 0;
        }
        public Thucphamdh(int sh)
        {
            this.Sohop = sh;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("so hop:");
            Sohop = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so hop la {0}", Sohop);
            Console.WriteLine("tong tien thuc pham dong hop {0}", Sohop * Price);
            
        }
    }
}
