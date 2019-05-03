using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrog2244
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.Nik = "18112244";
            kry1.Nama = "Hendri";
            kry1.GajiBulanan = 4000000;

            Karyawan kry2 = new Karyawan();
            kry2.Nik = "10012001";
            kry2.Nama = "Samuel";
            kry2.GajiBulanan = 3000000;

            Console.WriteLine("No. \tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiikkk naik gaji 10%!!!");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.ReadKey();
        }
    }
}
