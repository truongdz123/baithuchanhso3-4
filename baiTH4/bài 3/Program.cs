using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace _4._3
{
    class Person
    {
        private double[] dsd;

        private int n;
        private string hoten;
        private int namsinh;
        public Person()
        {
            hoten = "";
            namsinh = 0;
            dsd = new double[9];
        }
        public Person(string hoten, int namsinh, int n)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;

            dsd = new double[9];
        }
        public void nhaptt()
        {


            Console.WriteLine("nhap ten"); hoten = Console.ReadLine();
            Console.WriteLine("nhap nam sinh"); namsinh = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("nhap diem  thu" + i);
                dsd[i] = double.Parse(Console.ReadLine());
            }
        }

        public void hien()
        {
            Console.WriteLine("ho teb\t\t" + hoten);
            Console.WriteLine("namsinh\t\t" + namsinh);
            Console.WriteLine("diem cac mon");

            for (int i = 0; i < 9; i++)
            {
                Console.Write("|{0}|\t", dsd[i]);
            }
            Console.WriteLine();
            Console.WriteLine("diem tb la:\t" + tinhtb());
        }
        public double tinhtb()
        {
            double a = 0;
            double b = 0;
            for (int i = 0; i < 9; i++)
            {
                if (dsd[i] != 0)
                {
                    a = a + dsd[i];
                    b++;
                }
            }
            return a / b;
        }
        public bool ktra()
        {
            bool oke = false;
            return oke;

            for (int i = 0; i < 9; i++)
            {

                if (dsd[i] >= 5)

                    return true;
                else
                    return false;
            }
        }
        public double kiemtra()
        {
            if (ktra() == true)
            {
                if (tinhtb() > 7)
                {
                    return 1;
                }
                else
                    return -1;
            }
            else
                return 0;
        }
    }


    class QL
    {
        private Person[] ds;
        private int n;

        public void nhap()
        {
            Console.WriteLine("nhap so luong sv"); n = int.Parse(Console.ReadLine());
            ds = new Person[n];
            for (int i = 0; i < n; i++)
            {
                ds[i] = new Person();
                ds[i].nhaptt();
            }
        }
        public void hien()
        {
            for (int i = 0; i < n; i++)
            {
                ds[i].hien();
                Console.WriteLine();
            }
        }

        public double Luanvan()
        {
            double a = 0;
            for (int i = 0; i < n; i++)

                if (ds[i].kiemtra() == 1)
                    a++;
            return a;
        }
        public double totghiep()
        {
            double b = 0;
            for (int i = 0; i < n; i++)

                if (ds[i].kiemtra() == -1)
                    b++;
            return b;

        }
        public double thilai()
        {
            double c = 0;
            for (int i = 0; i < n; i++)

                if (ds[i].kiemtra() == 0)
                    c++;
            return c;

        }

    }
    class test
    {
        static void Main(string[] args)
        {
            QL a = new QL();
            a.nhap(); a.hien();
            Console.WriteLine("so hoc sinh lam luan van" + a.Luanvan());
            Console.WriteLine("so hoc sinh tot nghieo" + a.totghiep());
            Console.WriteLine("so sinh vien thi lai" + a.thilai());
            Console.ReadLine();
        }
    }
}