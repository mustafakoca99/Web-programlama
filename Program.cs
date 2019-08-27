using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virüs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilgilendirme
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("BİLGİSAYARINIZA ÇOK BÜYÜK BİR VİRÜS BULAŞTI TEMİZLEMEK İÇİN 'ENTER' TUŞUNA BASIN");
            Console.ReadLine();
            //geçiş yapmadan önceki kısım renklendirme
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            //bilgilendirme kısmı burası
            Console.WriteLine("bilgisayar iP numaranız bizim için çok önemli...");
            Console.ReadLine();
            string ip;
            ip = "";
            Console.WriteLine("ip numaranız ile pc'ye erişip virüsü temizleyeceğiz");
            Console.ReadLine();
            Console.Write(" İP NUMARANIZ=");
            Console.ReadLine();
            //renk tasarım kısmı
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            //kişinin ismini,soyismini, yaşına burada yer verecegiz
            string isim;
            isim = "";
            Console.WriteLine("1-isminiz=", isim);
            string soyisim;
            soyisim = "";
            Console.WriteLine("2-soyisminiz=", soyisim);
            string yas;
            yas = "";
            Console.WriteLine("3-yasınız=", yas);
            Console.ReadLine();
            //doğru bilgilermi değil mi diye inandırıcılık için sor
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("BİLGİLERİN DOĞRUMU ('EVET' YADA 'HAYIR' YAZ)");
            string deger;
            deger = "";
            Console.WriteLine("", deger);
            Console.ReadLine();
            //temizlendi diye bir komut ver
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("BİLGİSAYARIN ARTIK ESKİSİNDEN DAHA TEMİZ...", deger);
            Console.ReadLine();

        }
    }
}
