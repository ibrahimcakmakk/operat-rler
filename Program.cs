using System;

namespace operatörler
{
    class Program
    {
        static void Main(String[] args)
        {

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //mantıksal operatörler

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("perfect");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("great");
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("fine!");
            }

            //ilişkisel Operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);

            //Aritmetik operatör

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sayi1 += 1;
            Console.WriteLine(sayi1);

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }

}