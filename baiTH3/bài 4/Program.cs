using System;
using System.Security.Cryptography;

namespace bai_4
{
    class HocSinh
    {
        public double dtoan, dly, dhoa;
        private string hoten;

        public void nhap()
        {
            Console.WriteLine("nhap thong tin");
            Console.WriteLine("nhap ho ten"); hoten = Console.ReadLine();

            Console.WriteLine("nhap diem toan"); dtoan = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly"); dly = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa"); dhoa = double.Parse(Console.ReadLine());

        }
        public void hien()
        {
            Console.WriteLine("hoten\t\tdiem toan\t\tdiem ly\t\tdiem hoa");
            Console.WriteLine(hoten + "\t\t" + dtoan + "\t\t\t" + dly + "\t\t\t" + dhoa);
        }
    }
    class Quanli
    {
        private HocSinh[] ds;
        private int n;
        public void nhap()
        {
            Console.WriteLine("nhap ds hoc sinh"); n = int.Parse(Console.ReadLine());
            ds = new HocSinh[n];
            for (int i = 0; i < n; i++)
            {
                ds[i] = new HocSinh();
                ds[i].nhap();
            }
        }
        public void hiends()
        {
            for (int i = 0; i < n; i++)
            {
                ds[i].hien();
                Console.WriteLine();
            }
        }
        public void thilai()
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].dhoa < 5) ds[i].hien();
                else if (ds[i].dtoan < 5) ds[i].hien();
                else if (ds[i].dly < 5) ds[i].hien();
                else
                    Console.WriteLine();
            }
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Quanli diem = new Quanli();
            diem.nhap(); Console.Clear();
            Console.WriteLine("dnah sach");
            diem.hiends();

            Console.WriteLine("hs thi lai");
            diem.thilai();

            Console.ReadKey();
        }
    }
}