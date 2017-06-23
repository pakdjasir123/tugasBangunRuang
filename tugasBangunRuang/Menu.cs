using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Menu
    {
        public int pilih;

        public void menu()
        {
            Console.WriteLine("PROGRAM MENGHITUNG LUAS BANGUN RUANG ");
            Console.WriteLine();
            Console.WriteLine("Pilihlah Menu Dibawah Ini:");
            Console.WriteLine("1. Kerucut");
            Console.WriteLine("2. Tabung");
            Console.WriteLine("3. Bola");
            Console.WriteLine("4. Kubus");
            Console.Write("Masukkan Pilihan : ");
            pilih = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (pilih)
            {
                case 1:
                    {
                        Kerucut a = new Kerucut();

                        Console.WriteLine("Menghitung Luas Selimut Kerucut");
                        Console.WriteLine("---------------------------");
                        Console.Write("jari-jari : ");
                        a.jarijari = (int.Parse(Console.ReadLine()));
                        Console.Write("sisi   : ");
                        a.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas    = {0} cm2", a.luas_kerucut());

                        break;
                    }
                case 2:
                    {
                        Tabung b = new Tabung();

                        Console.WriteLine("Menghitung Luas Selimut Tabung");
                        Console.WriteLine("---------------------------");
                        Console.Write("jari-jari : ");
                        b.jarijari = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi   : ");
                        b.tinggi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas    = {0} cm2", b.luas_tabung());

                        break;
                    }

                case 3:
                    {
                        Bola c = new Bola();

                        Console.WriteLine("Menghitung Luas Permukaan Bola ");
                        Console.WriteLine("------------------------");
                        Console.Write("jari-jari : ");
                        c.jarijari = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas   = {0} cm2", c.luas_bola());

                        break;
                    }

                case 4:
                    {
                        Kubus d = new Kubus();

                        Console.WriteLine("Menghitung Luas Permukaan Kubus");
                        Console.WriteLine("-------------------------");
                        Console.Write("sisi : ");
                        d.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas       = {0} cm2", d.luas_kubus());

                        break;
                    }
            }
        
        }

    }
}
