using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    class DikdortgenHesapService : IKoseliHesaplaService
    {
        public double AlanHesapla(double taban, double yukseklik)
        {
            return taban * yukseklik;
        }

        public double CevreHesapla(double taban, double yukseklik)
        {
            return 2 * (taban + yukseklik);
        }
    }
}
