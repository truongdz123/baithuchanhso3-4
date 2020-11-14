using System;
using System.Net.Http.Headers;

namespace bai_5
{
    class Vecto
    {
        private int n;
        private int[] a;
        public Vecto()
        {
            n = 2;
            a = new int[2];
        }
        public Vecto(int n)
        {
            this.n = n;
            a = new int[n];
        }
        public Vecto(Vecto v2)
        {
            this.n = v2.n;
            a = new int[n];
        }
        public void nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]\t", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void hien()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t", a[i]);

            }
            Console.WriteLine();
        }
        public Vecto tong(Vecto v2)
        {
            if (this.n == v2.n)
            {
                Vecto v = new Vecto();
                for (int i = 0; i < n; i++)
                {

                    v.a[i] = this.a[i] + v2.a[i];

                }
                return v;
            }
            else
                return null;
        }
        public Vecto hieu(Vecto v2)
        {
            if (this.n == v2.n)
            {
                Vecto v = new Vecto();
                for (int i = 0; i < n; i++)
                {

                    v.a[i] = this.a[i] - v2.a[i];
                }

                return v;
            }
            else
                return null;
        }
        public Vecto tich(Vecto v2)
        {
            if (this.n == v2.n)
            {
                Vecto v = new Vecto();
                for (int i = 0; i < n; i++)
                {

                    v.a[i] = this.a[i] * v2.a[i];
                }

                return v;
            }
            else
                return null;
        }
    }
    class test
    {

        static void Main(string[] args)
        {
            Vecto v1 = new Vecto(); Console.WriteLine("nhap tt vecto");
            v1.nhap(); v1.hien();
            Vecto v2 = new Vecto(); Console.WriteLine("nhap tt vecto 2");
            v2.nhap(); v2.hien();
            Vecto v3 = v1.tong(v2);
            Vecto v4 = v1.hieu(v2);
            Vecto v5 = v1.tich(v2);
            if (v3 == null)
            {
                Console.WriteLine("khong cung chieu");
            }
            else
                Console.WriteLine("tong 2vecto");
            v3.hien();
            Console.WriteLine("hieu2vecto"); v4.hien();
            Console.WriteLine("tich 2vecto"); v5.hien();
            Console.ReadKey();
        }
    }
}