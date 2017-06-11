using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
// Viết chương trình nhập họ tên,điểm toán ,lý hóa,rồi tính tổng điểm
// (theo hướng đối tượng)
// ---------------------------------------- 
// ho ten : < họ tên >
// Điểm toán<diem toan>
// điểm lý
// diem hoa:<diem hoa>
// tong điểm
// nếu trung bình ba môn >5 đậu
// ------------------------------------------ 
// 

namespace baitaptulam
{
    class bai1
    {
        private string hoten;

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }
        public bai1()
        {
            Hoten = "rỗng";
        }
        public bai1(string ht)
        {
            this.Hoten = ht;
        }

        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten");
            Hoten = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("hoc sinh {0}",Hoten);

        }
    }
}