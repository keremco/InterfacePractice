using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    internal class DaireHesapService : IKosesizHesapService
    {
        
        public double AlanHesapla(double yariCap)
        {
             return Math.PI * Math.Pow(yariCap,2);
        }

        public double CevreHesapla(double yariCap)
        {
            return 2 * Math.PI * yariCap;
        }
    }
}
