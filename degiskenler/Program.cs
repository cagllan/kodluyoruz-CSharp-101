using System;

namespace degiskenler // Note: actual namespace depends on the project name.
{
    class Program
    {
        public static void Main(string[] args)
        {

            //  byte
            byte b = 5;
            sbyte c = 5;

            // short - unsigned short
            short s = 5;
            ushort us = 5;

            // integer
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // unsigned int
            uint ui = 4;

            // long 
            long l = 4;
            ulong ul = 4;

            // float 
            float f = 5;

            // double 
            double d = 5;

            // decimal 
            decimal de = 5;

            // char
            char ch = '2';

            // String 
            string str = "Chris";

            // bool
            bool bl1 = true;
            bool bl2 = false;
            bool bl3 = 10 < 2;

            // object
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = "";
            string str1a = null;
            string str1b = string.Empty;

            str1b = "Caglan Atay";

            string ad = "Caglan";
            string soyad = "Atay";
            string tamisim = ad + " " + soyad;

            // değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            // datetime 
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
