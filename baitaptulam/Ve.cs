using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptulam
{
    class Ve
    {
        private string ms;
        private string ten;
        private int namsinh;
        private int sotrochoi;
        public string Ms
        {
            get
            {
                return ms;
            }

            set
            {
                ms = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public int Namsinh
        {
            get
            {
                return namsinh;
            }

            set
            {
                namsinh = value;
            }
        }

        public int Sotrochoi
        {
            get
            {
                return sotrochoi;
            }

            set
            {
                sotrochoi = value;
            }
        }
        public  Ve()
        {
            Ten = "rong";
            Sotrochoi = 0;
            Ms = "rong";
            Namsinh = 0;
        }
        
        public virtual void nhap()
        {
            Console.WriteLine("nhap ten:");
            Ten = Console.ReadLine();
            Console.WriteLine("nhap ma so:");
            Ms = Console.ReadLine();
            Console.WriteLine("nhap nam sinh:");
            Namsinh = int.Parse(Console.ReadLine());

        } 
    }
}
