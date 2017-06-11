using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptulam
{
    
    class bai1_2:bai1
    {
        public delegate void Myd();
        private float diemtoan;
        private float diemhoa;
        private float diemnly;
        private float tongdiem;

        public float Diemtoan
        {
            get
            {
                return diemtoan;
            }

            set
            {
                diemtoan = value;
            }
        }

        public float Diemhoa
        {
            get
            {
                return diemhoa;
            }

            set
            {
                diemhoa = value;
            }
        }

        public float Diemnly
        {
            get
            {
                return diemnly;
            }

            set
            {
                diemnly = value;
            }
        }

        public float Tongdiem
        {
            get
            {
                return tongdiem;
            }

            set
            {
                tongdiem = value;
            }
        }
        public bai1_2()
        {
            Diemhoa = -1.1111f;
            Diemnly = -1.1111f;
            Diemtoan = -1.1111f;
            Tongdiem = -1.1111f;
        }
       public bai1_2(float dh,float dt,float dl,float td)
        {
            this.Diemhoa = dh;
            this.Diemnly = dl;
            this.Diemtoan = dt;
            this.Tongdiem = td;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap diem toan");
            Diemtoan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa");
            Diemhoa = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly");
            Diemnly = float.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("diem mon toan {0}", Diemtoan);
            Console.WriteLine("diem mon hoa {0}", Diemhoa);
            Console.WriteLine("diem mon ly {0}", Diemnly);
            float a=Tongdiem = Diemhoa + Diemnly + Diemtoan;
            Console.WriteLine("tong diem:{0}", Tongdiem);
            Myd kt = () =>
            {
                if(a<15)
                {
                    Console.WriteLine("ROT");
                }
                else
                {
                    Console.WriteLine("dau");
                }
//                 try
//                 {
//                     
//                     if ((a/3-5)==0||(a/3-5)<0)
//                     {
//                         a = 0;
//                     }
//                     float d = 1 / a;
//                     Console.WriteLine("PASS");
//                 }
//                 catch(DivideByZeroException dbze)
//                 {
//                     Console.WriteLine(dbze.Message);
//                     //throw;
//                 }

            };
            kt();
        }
        
       
    }
}
