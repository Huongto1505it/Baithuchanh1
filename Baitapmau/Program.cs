using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapmau
{
    struct Sinhvien
    {
        public string malop, masv, tensv;
        public int namsinh;
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", malop, masv, tensv, namsinh);
        }
    }
    class Node
    {
        public Sinhvien info;
        public Node next;
    }
    class List
    {
        public Node Head, Tail;
        public List()
        {
            Head = Tail = null;
        }
        public void Hienthi()
        {
            Node P = Head;
            while (P != null)
            {
                Console.Write(P.info + "\t");
                P = P.next;
            }
            Console.WriteLine();
        }
        public void Them(Sinhvien x)
        {
            Node P = new Node();
            P.info = x;
            P.next = null;
            if (Head == null)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.next = P;
                Tail = P;
            }

        }
        public void Timkiem(string x)
        {
            Node P = new Node();
            while (P != null)
            {
                if (P.info.masv == x)
                {
                    P.info.namsinh = 2000;
                    P = P.next;
                }
                else
                    Console.WriteLine("{0} khong ton tai trong danh sach", x);
                        
            }
        }
        public void Xoa(string x)
        {
            Node P = new Node();
            Node t = P;
            while (P != null && P.info.masv != x)
            {
                t = P;
                P = P.next;
            }
            if (P == null) Console.WriteLine("X khong ton tai trong danh sach");
            else
            {
                if (P == Head) Head = Head.next;
                else if (P.next == null) t.next = null;
                else t.next = P.next;
            }
        }
        public int Dem(string x)
        {
            Node P = new Node();
            int d = 0;
            while (P != null)
            {
                if (P.info.malop == x)
                {
                    d += 1;
                    P = P.next;
                }

            }
            return d;
        }
        



    }
    class Program
    {
        static void Main(string[] args)
        {
            List lis = new List();
            Sinhvien sv;
            Console.Write("Nhap danh sach sinhvien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap cong nhan thu {0}", i + 1);
                Console.Write("Ma lop ");
                sv.malop = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                sv.masv = Console.ReadLine();
                Console.Write("Ten sinh vien: ");
                sv.tensv = Console.ReadLine();
                Console.Write("Nam sinh: ");
                sv.namsinh =int.Parse( Console.ReadLine());
                lis.Them(sv);

            }
            Console.WriteLine("Danh sach sinh vien sau khi them la: ");
            
            lis.Hienthi();

            Console.ReadKey();
        }
    }
   
}
