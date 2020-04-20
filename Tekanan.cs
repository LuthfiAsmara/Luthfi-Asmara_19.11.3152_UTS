using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFIsika
{
    class Tekanan
    {
        public void tek()
        {
            Console.Write("Masukkan nilai Gaya : ");
            int gaya = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Luas Penampang : ");
            int luas = int.Parse(Console.ReadLine());

            double nilaiTekanan = gaya / luas;
            Console.WriteLine("Besarnya Tekanan adalah : " + (nilaiTekanan));
        }
    }
}
