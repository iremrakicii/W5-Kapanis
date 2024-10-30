using W5_Kapanis;

class Program
{
    static void Main()
    {
        bool Value = false;
        while (!Value)
        {
        baslangic1:
            try
            {
                Console.WriteLine("Merhaba Araba üretmek ister misiniz? Üretmek isterseniz 'e' harfini istemiyorsanız 'h' harfini tuşlayın.");
                string cevap = Console.ReadLine().ToLower();


                if (cevap == "h")
                {
                    Console.WriteLine("Program sonlandırılıyor...");
                    break;
                }

                else if (cevap == "e")
                {
                    List<Araba> Arabalar = new List<Araba>();
                    Araba araba = new Araba();
                    Console.WriteLine("İstediğiniz arabanın aşağıdaki bilgilerini girer misiniz?");
                    Console.Write("Modeli:"); araba.model = Console.ReadLine();
                    Console.Write("Markası:"); araba.marka = Console.ReadLine();
                    Console.Write("Rengi:"); araba.renk = Console.ReadLine();

                baslangic2:
                    Console.Write("Kapı sayısı:");
                    try
                    {
                        araba.kapiSayisi = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar giriş yapın.");
                        goto baslangic2;
                    }

                    Console.Write("Seri Numarası:"); araba.seriNumarasi = Console.ReadLine();
                    araba.uretımTarıhı = DateTime.Now;
                    Console.Write($"Üretim Tarihi: {araba.uretımTarıhı}");

                    Arabalar.Add(araba);
                    Console.WriteLine("Araba başarıyla üretildi.");
                    Console.WriteLine("Yeni bir araba üretmek ister misiniz? (e/h)");
                    string cevap2 = Console.ReadLine().ToLower();
                    if (cevap2 == "h")
                    {
                        Console.WriteLine("\nAraba Listesi:");
                        foreach (var item in Arabalar)
                        {
                            item.BilgileriYazdir();
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrardan araba üretmek için sizi anasayfaya yönlendiriyorum!");
                        goto baslangic1;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz formatta işlem yaptınız.");
            }
            finally
            {

            }
        }


    }
}
