using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2.Services
{
    internal class DaireHesapService : IKosesizHesapService
    {
        public bool PiUzunMu { get; set; } = true;
        public double AlanHesapla(double yariCap)
        {
             return PiUzunMu ? Math.PI * Math.Pow(yariCap,2) : 3.14 * Math.Pow(yariCap,2);
        }

        public double CevreHesapla(double yariCap)
        {
            return PiUzunMu ? 2 * Math.PI * yariCap : 2 * 3.14 * yariCap;
        }
    }
}
