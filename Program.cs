namespace Abstract
{
    public class Program
    {
        static void Main(string[] args)
        {
           Calisan magazaYoneticisi = new MagazaYoneticisi { Ad = "Mehmet", Soyadi = "Yüksel", Departman = "Mağaza Müdürü" };
            Calisan projeYoneticisi = new ProjeYoneticisi { Ad = "Merve", Soyadi = "Çelik", Departman = "Proje Yönetimi" };
            SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi { Ad = "Enes", Soyadi = "Kaya", Departman = "Satış" };

            magazaYoneticisi.Gorev();
            projeYoneticisi.Gorev();
            satisTemsilcisi.Gorev();
        }
    }
}
