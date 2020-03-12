using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_dinamis

{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Title = "Aplikasi kalkulator dinamis";
                Console.WriteLine();
                Console.WriteLine("|-------------------|");
                Console.WriteLine("|    MENU UTAMA     |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine("|1=>Penjumlahan     |");
                Console.WriteLine("|2=>Pengurangan     |");
                Console.WriteLine("|3=>Perkalian       |");
                Console.WriteLine("|4=>Pembagian       |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine();
                Console.WriteLine("MASUKAN MENU ANDA [1,2,3,4] : ");
                int K = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (K == 1)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (K == 2)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (K == 3)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + perkalian(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (K == 4)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + pembagian(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("MAAF,INPUTAN ANDA SALAH");
                    Console.WriteLine();
                    Console.WriteLine("\nTEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();

                }
                int penambahan(int a, int b)
                {
                    return a + b;
                }
                int pengurangan(int a, int b)
                {
                    return a - b;
                }
                int perkalian(int a, int b)
                {
                    return a * b;
                }
                int pembagian(int a, int b)
                {
                    return a / b;
                }
            }
       
    }

}

