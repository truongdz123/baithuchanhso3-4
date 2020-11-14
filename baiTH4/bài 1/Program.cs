using System;
using System.Runtime.InteropServices;

namespace _4._1
{
    class Matran
    {
        public static int n;
        private int[,] a;
        public Matran()
        {
            n = 0;
            a = new int[10, 10];
        }
        public Matran(int n)
        {

            a = new int[n, n];
        }

        public void nhap()
        {
            Console.WriteLine("nhap cap  mt"); n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0} {1}]", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void hien()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)

                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();

            }
        }
        public Matran tong(Matran t2)
        {
            Matran t = new Matran(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)

                    t.a[i, j] = this.a[i, j] + t2.a[i, j];

            }
            return t;
        }
        public Matran hieu(Matran t2)
        {

            Matran t = new Matran();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)

                    t.a[i, j] = this.a[i, j] - t2.a[i, j];

            }
            return t;
        }
    }
    class QUANLI
    {
        private Matran[] ds;
        private int s;
        public void nhap()
        {
            Console.WriteLine("nhap so luong ma tran"); s = int.Parse(Console.ReadLine());
            ds = new Matran[s];
            for (int i = 0; i < s; i++)
            {
                ds[i] = new Matran();
                ds[i].nhap();
            }
        }
        public void hien()
        {
            Console.WriteLine("cac ma tran");
            for (int i = 0; i < s; i++)
            {
                ds[i].hien();
            }
        }
        public void tinhtong()
        {
            Matran a = ds[0];

            for (int i = 1; i < s; i++)
            {
                a = ds[0].tong(ds[i]);
                a.hien();
            }

        }
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            QUANLI q = new QUANLI();
            q.nhap(); q.hien();
            Console.WriteLine("tong cac matran");
            q.tinhtong();
            Console.ReadKey();
        }
    }
}