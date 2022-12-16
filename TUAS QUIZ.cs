/*
NAUFAL AL-MAHDY AMARA PUTRA (2207125069)
Teknik Informatika B
*/

using System;
namespace DasPro
{
    class Program
    {
        static void Main(string[] args)
        {
           int andaRandomNum;
           int komputerRandomNum;

           int pointAnda = 0;
           int pointKomputer = 0;

           Random random = new Random();
            
           for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Pada Game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran anda akan di lempar menghasilkan nilai random");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine();
            Console.ReadKey();

            andaRandomNum = random.Next(1, 7);
            Console.WriteLine("Nilai Anda " + andaRandomNum); 

            System.Threading.Thread.Sleep(1000);

            komputerRandomNum = random.Next(1, 7);
            Console.WriteLine("Nilai Komputer " + komputerRandomNum);

            if(andaRandomNum > komputerRandomNum)
                {
                    pointAnda++;
                    Console.WriteLine("Anda Menang Ronde Ini");
                }
                else if(andaRandomNum < komputerRandomNum)
                {
                    pointKomputer++;
                    Console.WriteLine("Komputer Menang Ronde Ini");
                }
                else
                {
                    Console.WriteLine("SERI");
                }

                Console.WriteLine("SKOR ANDA     :" +pointAnda );
                Console.WriteLine("SKOR KOMPUTER :" +pointKomputer );
            }
            if(pointAnda > pointKomputer)
            {
                Console.WriteLine("Anda Menang");
            }
            else if(pointAnda < pointKomputer)
            {
                Console.WriteLine("Anda Kalah");
            }
            else
            {
                Console.WriteLine("SERI");
            }
            Console.ReadKey();
        }
    }
}