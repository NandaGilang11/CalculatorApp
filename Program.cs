using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Sederhana\n");
            Console.WriteLine("1.Penambahan\n");
            Console.WriteLine("2.Pengurangan\n");
            Console.WriteLine("3.Perkalian\n");
            Console.WriteLine("4.Pembagian\n");

            int angka1 = 0;
            int angka2 = 0;

            Console.WriteLine("Masukkan angka pertama = ");
            angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua = ");
            angka2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan operator : ");
            switch (Console.ReadLine())
            {
                case "1":
                    var total = penjumlahan(angka1, angka2);
                    Console.WriteLine("\nHasil = " + total);
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
                    break;
                case "2":
                    var totalKurang = pengurangan(angka1, angka2);
                    Console.WriteLine("\nHasil = " + totalKurang);
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
                    break;
                case "3":
                    var totalKali = perkalian(angka1, angka2);
                    Console.WriteLine("\nHasil = " + totalKali);
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
                    break;
                case "4":
                    double totalBagi = pembagian(angka1, angka2);
                    Console.WriteLine("\nHasil = " + totalBagi);
                    Console.WriteLine("\nTekan sembarang tombol untuk keluar");
                    Console.ReadKey();
                    break;
            } 
        }

        private static int penjumlahan(int nilai1, int nilai2)
        {
            return nilai1 + nilai2;
        }
        private static int pengurangan(int nilai1, int nilai2)
        {
            return nilai1 - nilai2;
        }
        private static int perkalian(int nilai1, int nilai2)
        {
            return nilai1 * nilai2;
        }
        private static double pembagian(int nilai1, int nilai2)
        {
            return (double) nilai1 / nilai2;
        }
    }
}
