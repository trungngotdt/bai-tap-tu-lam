using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace baitaptulam
{

    class Program
    {

      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Lam b = new Lam();

           b.bai();
           

             Func<float, float> tinhgiaithua = (float a) =>
             {
                 float i; float d = 0; float s = 0;
                 for (i = 1; i <= a; i++)
                 {
                     d = d + i;
                     Console.WriteLine("i{0}", i);
                     s = s+1/d;
                     Console.WriteLine("d:{0}",d);
                     Console.WriteLine("s{0}", s);
 
                 
                 }
 
                 return s;
             };

            //tinhgiaithua(6);
            
            Console.ReadLine();

        }

    }
}

