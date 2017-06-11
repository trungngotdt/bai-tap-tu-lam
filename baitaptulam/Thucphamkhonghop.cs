using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptulam
{
    class Thucphamkhonghop:Bai2_thucpham
    {
        private int khoiluong;

        public int Khoiluong
        {
            get
            {
                return khoiluong;
            }

            set
            {
                khoiluong = value;
            }
        }
        public Thucphamkhonghop()
        {
            Khoiluong = 0;
        }
        public Thucphamkhonghop(int kl)
        {
            this.Khoiluong = kl;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("khoi luong thuc pham:");
            Khoiluong = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("khoi luong la:{0}",Khoiluong);
            Console.WriteLine("tong tien:{0}", Khoiluong*Price);
        }
    }
}
