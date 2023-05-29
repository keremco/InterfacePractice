using InterfacesDemo2.Services;
using InterfacesDemo2.Services.Bases;

namespace InterfacesDemo2
{
    public partial class Form1 : Form
    {
        IKoseliHesaplaService _koseliHesapService;
        IKosesizHesapService _kosesizHesapService;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bKosesizHesapla_Click(object sender, EventArgs e)
        {
            _kosesizHesapService = new DaireHesapService()
            {
                PiUzunMu = false
            };
            double alan = _kosesizHesapService.AlanHesapla(Convert.ToDouble(tbYaricap.Text.Trim()));

            double cevre = _kosesizHesapService.CevreHesapla(Convert.ToDouble(tbYaricap.Text.Trim()));

            lSonuc.Text = $"Alan: {alan} \r\n Çevre: {cevre}";
        }
    }
}