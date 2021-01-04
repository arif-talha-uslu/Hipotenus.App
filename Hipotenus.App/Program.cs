using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipo.Tenüs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dik iki kenarı verilen bir Dik üçgenin Hipotenüsünü bulalım(Tam sayı hipotenüs bulabiliyoruz henüz):");

            Console.WriteLine("Önce dik birinci kenarı girin:");
            int kenar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Şimdi diğer dik kenar uzunluğunu girin:");
            int kenar2 = int.Parse(Console.ReadLine());

            int kenkar1 = (int)(kenar1 * kenar1);
            int kenkar2 = (int)(kenar2 * kenar2);
            int kartop = (int)(kenkar1 + kenkar2);
            double h;
            h = kartop;
            Console.WriteLine("Hipotenüs:");
            Console.WriteLine(Math.Sqrt(kartop));
            Console.ReadKey();
        }
    }
}
