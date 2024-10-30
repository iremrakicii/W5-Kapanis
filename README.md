# Araba Üretim Uygulaması

Bu uygulama, kullanıcıların araba bilgilerini girerek yeni bir araba "üretmelerini" ve tüm üretilen arabaların bilgilerini listelemelerini sağlar.

## Özellikler

- **Araba Bilgisi Girişi**: Kullanıcı, araba modeli, markası, rengi, kapı sayısı ve seri numarasını girebilir.
- **Üretim Tarihi**: Her araba için üretim tarihi otomatik olarak atanır.
- **Araba Listesi**: Kullanıcı, ürettiği tüm arabaların bilgilerini görüntüleyebilir.

## Kod Detayları

- **Araba Sınıfı**: `Araba` sınıfı, araba özelliklerini kapsar (`model`, `marka`, `renk`, `kapiSayisi`, `seriNumarasi`, `uretımTarıhı`). Ayrıca `BilgileriYazdir` metodu ile arabaların detayları ekrana yazdırılır.
- **Program Sınıfı**: `Program` sınıfında kullanıcıdan bilgi alınır ve araba üretim işlemleri gerçekleştirilir.

### Kullanılan Özellikler

- **Özellikler (Properties)**: `Araba` sınıfı özellikleri (`uretımTarıhı`, `seriNumarasi`, `marka`, `model`, `renk`, `kapiSayisi`) tanımlanır.
- **Try-Catch Yapısı**: Kapı sayısı girişinde hatalı giriş yapılması durumunda programın hata vermemesi sağlanır.
- **While Döngüsü**: Kullanıcı, birden fazla araba üretmek istediğinde döngü devam eder.
- **Goto İfadesi**: Hatalı girişlerde veya tekrar araba üretmek istendiğinde kullanıcı, döngü başına yönlendirilir.

## Kullanım

1. Program başlatıldığında, kullanıcıya araba üretmek isteyip istemediği sorulur.
2. Kullanıcı `e` girerse araba bilgilerini girer, `h` girerse program sonlanır.
3. Tüm bilgiler girildikten sonra araba "üretilir" ve araba listesine eklenir.
4. Kullanıcı yeni bir araba üretmek isteyip istemediğine karar verir.
5. `h` girildiğinde program, üretilen tüm arabaların listesini ekrana yazdırır.

