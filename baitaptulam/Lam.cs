using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace baitaptulam
{
    class Lam
    {

 
        public delegate void mydelegate();
       
        public void bai()
        {
            #region bai1
        mydelegate  bai1 = () =>
        {
            int i;
            ArrayList bai01 = new ArrayList();
            
            do
            {
                bai1_2 hs = new bai1_2();
                hs.nhap();
                bai01.Add(hs);
                
                Console.WriteLine("1 de tiep tuc 0 de dung lai");
                i = Int16.Parse(Console.ReadLine());
            }
            while (i > 0);
            foreach (bai1_2 item in bai01)
            {
                item.xuat();
                if (item.Diemhoa==0)
                {
                    Console.WriteLine("te");
                }
            }
        };
        #endregion
            #region bai2
        mydelegate bai2 = () =>
        {
            int j;
            ArrayList bai02 = new ArrayList();
           
           
                
                Thucphamkhonghop tpkh = new Thucphamkhonghop();
                Console.WriteLine("chon loai thuc pham:1/dong hop\n2.khong hop");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                    do
                    {
                        Thucphamdh tpdh = new Thucphamdh();
                        bai02.Add(tpdh);
                        tpdh.nhap();
                        j = int.Parse(Console.ReadLine());

                    } while (j == 0);
                    foreach (Bai2_thucpham item in bai02)
                    {
                        item.xuat();
                    }
                        break;
                case 2:
                    do
                    {
                        bai02.Add(tpkh);
                        tpkh.nhap();
                        j = int.Parse(Console.ReadLine());

                    } while (j == 0);
                    foreach (Bai2_thucpham item in bai02)
                    {
                        item.xuat();
                    }
                       

                    break;
                    default:
                        break;
                }


                

           
            foreach (var item in bai02)
            {

            }
            //kh.xuat();tpdh.xuat();
        };
            #endregion
            
          //bai1();
            #region tinh tong n so
            Func<float, float> tinhtongnso = (float a) =>
            {
                float i; float d = 0; float s = 0;
                for (i = 1; i <= a; i++)
                {
                    d = d + i;
                    Console.WriteLine("i{0}", i);
                    s = s + 1 / d;
                    Console.WriteLine("d:{0}", d);
                    Console.WriteLine("s{0}", s);


                }

                return s;
            };

            #endregion
            #region demo ve hashtable


            mydelegate vd = () =>
            {
                ArrayList arry1 = new ArrayList();
                Hashtable hash1= new Hashtable();
                
                
                hash1.Add(0, 1);
                hash1.Add(6, 5);
                hash1.Add(9, 66);int diem= 0;
                do
                {
                    vd g = new vd();
                    g.nhap();
                    arry1.Add(g);
                    
                    diem++;

                } while (diem< 4);
                ICollection k = hash1.Keys;
                foreach (vd item in arry1)
                {
                    if (!hash1.ContainsKey(item.s))
                    {
                        Console.WriteLine("rong");continue;
                    }
                    
                    //int gh;
                    //gh = item.nhap();
                    Console.WriteLine("vay co trong hashtable");
                   Console.WriteLine(hash1[item.s]);
                   
                }
               
            };


            #endregion
            vd();
            
        }
        


    }
}
    


