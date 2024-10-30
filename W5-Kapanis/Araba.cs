namespace W5_Kapanis
{
    public class Araba
    {
        private DateTime _uretımTarıhı;
        private string _seriNumarasi;
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapiSayisi;

        public DateTime uretımTarıhı
        {
            get
            {
                return _uretımTarıhı;
            }
            set
            {
                _uretımTarıhı = value;
            }
        }
        public string seriNumarasi
        {
            get
            {
                return _seriNumarasi;
            }
            set
            {
                _seriNumarasi = value;
            }
        }
        public string marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value;
            }
        }
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string renk
        {
            get
            {
                return _renk;

            }
            set
            {
                _renk = value;
            }
        }
        public int kapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                _kapiSayisi = value;
            }

        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Modeli: {_model}, Markası: {_marka}, Rengi: {_renk}, Kapı Sayısı: {_kapiSayisi}, Seri Numarası: {_seriNumarasi}, Üretim Tarihi: {_uretımTarıhı}");
        }




    }
}
