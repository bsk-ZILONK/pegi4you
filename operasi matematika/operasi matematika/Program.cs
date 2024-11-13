using System;
class Program
{
    static void Main()
    {
        // Contoh variabel
        int x = 10;
        int y = 5;

        Console.WriteLine($"{x} + {y} = {Tambah(x, y)}");
        Console.WriteLine($"{x} - {y} = {Kurang(x, y)}");
        Console.WriteLine($"{x} * {y} = {Kali(x, y)}");
        Console.WriteLine($"{x} / {y} = {Bagi(x, y)}");
    }

    static int Tambah(int a, int b)
    {
        return a + b;
    }

    static int Kurang(int a, int b)
    {
        return a - b;
    }

    static int Kali(int a, int b)
    {
        return a * b;
    }

    static string Bagi(int a, int b)
    {
        if (b != 0)
        {
            return (a / (double)b).ToString(); // Pembagian dengan hasil desimal
        }
        else
        {
            return "Tidak bisa membagi dengan nol!";
        }
    }
}
                                                                 