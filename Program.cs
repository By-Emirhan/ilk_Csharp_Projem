using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double seçim, adet, toplam = 0,indirim;
            double hesap = 0;
            etiket:
            Console.Clear();
            Console.WriteLine("******************************BEYAZ EŞYA KATALOĞU******************************");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      1-Buzdolabı - 2000 TL          **     7-Mikrodalga Fırın - 1100 TL   **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      2-Bulaşık Makinası - 1500 TL   **     8-Tost Makinası  - 350 TL      **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      3-Ankastre Ocak - 840 TL       **     9-Blender seti - 250 TL        **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      4-Davlumbaz  - 1250 TL         **    10-Kahve Makinası - 175 TL      **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      5-Fırın - 1600 TL              **    11-Meyve Sıkacağı - 900 TL      **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("**      6-Beyaz Eşya Seti - 6600 TL    **    12-Çamaşır Makinası - 2900 TL   **");
            Console.WriteLine("**                                     **                                    **");
            Console.WriteLine("*******************************************************************************");
            
            {
                Console.WriteLine("");
                Console.Write("Alacağınız ürünün numarasını giriniz : ");
                seçim = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                if (seçim == 1)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2000;
                    hesap = hesap + toplam;
                }
                else if (seçim == 2)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1500;
                    hesap = hesap + toplam;
                }
                else if (seçim == 3)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 840;
                    hesap = hesap + toplam;
                }
                else if (seçim == 4)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1250;
                    hesap = hesap + toplam;
                }
                else if (seçim == 5)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1600;
                    hesap = hesap + toplam;
                }
                else if (seçim == 6)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6600;
                    hesap = hesap + toplam;
                }
                else if (seçim == 7)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1100;
                    hesap = hesap + toplam;
                }
                else if (seçim == 8)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 350;
                    hesap = hesap + toplam;
                }
                else if (seçim == 9)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 250;
                    hesap = hesap + toplam;
                }
                else if (seçim == 10)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 175;
                    hesap = hesap + toplam;
                }
                else if (seçim == 11)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 900;
                    hesap = hesap + toplam;
                }
                else if (seçim == 12)
                {
                    Console.Write("kaç Adet istersiniz : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2900;
                    hesap = hesap + toplam;
                }
                else

                Console.WriteLine("Böyle bir seçim yok");                             
                Console.WriteLine();
                Console.Write("Başka isteğiniz varmı : ");
                string cevap = Console.ReadLine();
                
                if (cevap == "e" || cevap == "E" || cevap == "EVET" || cevap == "evet")
                    
                goto etiket;
            }
            Console.Clear();
            Console.WriteLine("Toplam Tutar :" + hesap);

            if (hesap <= 2000)
            {
                indirim = hesap * 0.08;
                toplam = hesap - indirim;
                Console.WriteLine("*****************************************");
                Console.WriteLine("İndirim Miktarı {0}'TL", indirim);
                Console.WriteLine("*****************************************");
                Console.WriteLine("Ödencek Tutar {0}'TL", toplam);

            }
            else if (hesap > 2000 && hesap <= 10000)
            {
                indirim = hesap * 0.85;
                toplam = hesap - indirim;
                Console.WriteLine("*****************************************");
                Console.WriteLine("İndirim Miktarı {0}'TL", indirim);
                Console.WriteLine("*****************************************");
                Console.WriteLine("Ödencek Tutar {0}'TL", toplam);

            }
            else
            {
                indirim = hesap * 0.05;
                toplam = hesap - indirim;
                Console.WriteLine("*****************************************");
                Console.WriteLine("İndirim Miktarı {0}'TL", indirim);
                Console.WriteLine("*****************************************");
                Console.WriteLine("Ödencek Tutar {0}'TL", toplam);
             
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler  ");
            Console.WriteLine("*****************************************");
            Console.WriteLine("iyi günlerde kullanın");
            Console.WriteLine("*****************************************");
            Console.ReadKey();
        }
    }
}
