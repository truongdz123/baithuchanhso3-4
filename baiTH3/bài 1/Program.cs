using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace bai_1._1
{
    class Phanso
    {
        private int ts, ms;
        public Phanso()
        {
            ts = 0;
            ms = 1;
        }
        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ts"); ts = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ms "); ms = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("{0}/{1}", ts, ms);
        }
        public int usc(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public Phanso thugon()
        {
            int uc = usc(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public Phanso tong(Phanso t2)
        {
            Phanso t = new Phanso();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.thugon();
        }
        public Phanso tong2(int x)
        {
            Phanso t1 = new Phanso();
            t1.ts = this.ts * 1 + x * this.ms;
            t1.ms = this.ms * x;
            return t1.thugon();
        }
        public Phanso hieu(Phanso t2)
        {
            Phanso t = new Phanso();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.thugon();
        }
        public Phanso hieu2(int x)
        {
            Phanso t1 = new Phanso();
            t1.ts = this.ts * 1 - x * this.ms;
            t1.ms = this.ms * x;
            return t1.thugon();
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Phanso t = new Phanso();
            t.nhap(); t.hien();
            Phanso t2 = new Phanso();
            t2.nhap(); t2.hien();
            Phanso t3 = new Phanso();
            t3 = t.tong(t2); Console.WriteLine("Tong 2 phan so"); ; t3.hien();
            t3 = t.tong2(5);
            Console.WriteLine("tong phan so voi 1 so"); t3.hien();
            t3 = t.hieu(t2);
            Console.WriteLine("hieu 2 phan so"); t3.hien();
            t3 = t.hieu2(5); Console.WriteLine("hieu ps voi 1 so"); t3.hien();
            Console.ReadKey();
        }
    }
}