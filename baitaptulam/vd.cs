using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptulam
{
    class vd
    {
        public int s;
        public void nhap()
        {
            Console.WriteLine("nhap");
            s = int.Parse(Console.ReadLine());
            //return s;
        }
        public int xuat()
        {
            return s;
        }
    }
}
