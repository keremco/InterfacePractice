using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    class DikucgenHesapService : IKoseliHesaplaService
    {
        public double AlanHesapla(double taban, double yukseklik)
        {
            return taban * yukseklik / 2;
        }

        public double CevreHesapla(double taban, double yukseklik)
        {
            double hipotenus = (Math.Pow(taban,2) + Math.Pow(yukseklik,2));
            return taban + yukseklik + hipotenus;
        }
    }
}
