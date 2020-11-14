using System;

namespace bai_3
{
    class Time
    {
        private int gio, phut, giay;
        public Time()
        {
            gio = phut = giay = 0;
        }
        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }
        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        public int Giay
        {
            get { return giay; }
            set { giay = value; }
        }
        public void normalize(/*nt h, int m, int s*/)
        {
            phut += giay / 60;
            giay = giay % 60;
            gio += phut / 60;
            phut = phut % 60;
            gio = gio % 24;
        }
        public void advance(int h, int m, int s)
        {
            Time a = new Time(gio, phut, giay);
            a.gio = this.gio + h;
            a.phut = this.phut + m;
            a.giay = this.giay + s;
            a.normalize();
            Console.WriteLine("thoi gian sau chinh{0}gio{1}phut{2}giay", a.gio, a.phut, a.giay); ;
        }
        public void hien()
        {
            Console.WriteLine("thoi gian {0}gio{1}phut{2}giay", gio, phut, giay);
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Time t = new Time(25, 97, 80);
            t.normalize();
            t.hien();
            t.advance(3, 60, 41);
            Time a = new Time();
            Console.WriteLine("thoi gian hien tai");
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}