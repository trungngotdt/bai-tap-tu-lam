using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region de
//http://documents.tips/documents/bai-tap-lap-trinh-huong-doi-tuong-voi-c.html 
#endregion
namespace baitaptulam
{
    class Bai2_thucpham
    {
        private string name;
        private long price;
        private int numbers;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public long Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Numbers
        {
            get
            {
                return numbers;
            }

            set
            {
                numbers = value;
            }
        }

        public Bai2_thucpham()
        {
            Name = "rỗng";
            Price = 0;
            Numbers = 0;
        }
        public Bai2_thucpham(int soluong,string ten,long gia)
        {
            this.Name = ten;
            this.Price = gia;
            this.Numbers = soluong;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ten thuc pham:");
            Name = Console.ReadLine();
            Console.WriteLine("nhap gia thuc pham:");
            Price = long.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong");
            Numbers = int.Parse(Console.ReadLine());
        }
       
        public virtual void xuat()
        {
            Console.WriteLine("thuc pham {0} ", Name);
            Console.WriteLine("co gia {0}", Price);
            Console.WriteLine("so luong {0}", Numbers);
        }    
    }
}
