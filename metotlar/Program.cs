using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            // value type
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
             
            // instance
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            //  ref type
            int sonuc2 = ornek.ArttırveTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));  
            ornek.EkranaYazdir(Convert.ToString(a+b));   

           
        }

        // call by value
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
        
    }

   

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        // call by referance
        public int ArttırveTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2;
        }
    }
}
    


