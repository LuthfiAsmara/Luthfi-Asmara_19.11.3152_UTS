using System;

namespace RumusFIsika
{
    class Program
    {
        static void Main(string[] args)
        {
            MassaJenis yanga = new MassaJenis();
            Tekanan yangb = new Tekanan();
            
            Console.WriteLine("PROGRAM KALKULATOR FISIKA !\n");
            Console.WriteLine("a. Menghitung Massa Jenis");
            Console.WriteLine("b. Menghitung Tekanan\n");
            Console.WriteLine("Mana yang kamu pilih guys ? : ");
            char pilih = char.Parse(Console.ReadLine());


            if (pilih == 'a')
            {
                Console.WriteLine();
                yanga.mj();
            }
            if (pilih == 'b')
            {
                Console.WriteLine();
                yangb.tek();
            }

            Console.WriteLine("\nProgram Selesai - Terima Kasih");
        }
    }
}
