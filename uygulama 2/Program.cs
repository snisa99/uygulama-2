using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kontrol edeceğimiz sayıların bulunduğu liste
            List<int> sayilar = new List<int> { 12, 45, 150, 555, 789, 1024, 2048 };

            Console.Write("Aratmak istediğiniz sayıyı girin: ");
            string giris = Console.ReadLine();

            // Girilen değerin geçerli bir sayı olup olmadığını kontrol ediyoruz
            if (int.TryParse(giris, out int arananSayi))
            {
                // Contains metodu liste içinde sayı varsa true, yoksa false döner
                bool sonuc = sayilar.Contains(arananSayi);

                // Sonucu ekrana yazdırıyoruz
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz, lütfen bir sayı yazın.");
            }
        }   
    }
    
}
