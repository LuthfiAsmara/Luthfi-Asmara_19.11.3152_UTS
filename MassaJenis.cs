using System;
using System.Collections.Generic;
using System.Text;

namespace RumusFIsika
{
    class MassaJenis
    {
        public void mj()
        {
            Console.Write("Masukkan nilai Massa : ");
            int massa = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Volume : ");
            int vol = int.Parse(Console.ReadLine());

            double nilaiMjenis = massa / vol;
            Console.WriteLine("Besarnya Massa Jenis adalah : " + (nilaiMjenis));
        }
            
    }
}
