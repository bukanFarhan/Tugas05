using System;

namespace _19._11._2842_Tugas05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Numbers numbers = new Numbers();
           numbers.CariNilaiMin(20, 21);
           numbers.CariNilaiMin(100, 20, 11);
           numbers.CariNilaiMax(20, 21);
           numbers.CariNilaiMax(100, 20, 11);
        }
    }
}
