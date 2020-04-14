using System;

namespace ResponsiPemrograman2751
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan1 = new Karyawan(19112604, "Ardhika", 500000);
            Karyawan karyawan2 = new Karyawan(19112621, "Yudha", 400000);
            Karyawan karyawan3 = new Karyawan(19112626, "Prasetyo", 600000);


            Console.WriteLine("No. \t\t NIK \t\t Nama \t\t Gaji");
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("1. {0} \t {1} \t {2}", karyawan1.nik, karyawan1.nama, karyawan1.gajiBulanan);
            Console.WriteLine("2. {0} \t {1} \t {2}", karyawan2.nik, karyawan2.nama, karyawan2.gajiBulanan);
            Console.WriteLine("3. {0} \t {1} \t {2}", karyawan3.nik, karyawan3.nama, karyawan3.gajiBulanan);

            Console.WriteLine("\n\n Kenaikan Gaji 10% ");

            Console.WriteLine("No. \t\t NIK \t\t Nama \t\t Gaji");
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("1. {0} \t {1} \t {2}", karyawan1.nik, karyawan1.nama, karyawan1.naikGaji);
            Console.WriteLine("2. {0} \t {1} \t {2}", karyawan2.nik, karyawan2.nama, karyawan2.naikGaji);
            Console.WriteLine("3. {0} \t {1} \t {2}", karyawan3.nik, karyawan3.nama, karyawan3.naikGaji);

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }
        public int naikGaji { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }

            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            naikGaji = Convert.ToInt32(tmp) + gajiBulanan;
        }

    }
}