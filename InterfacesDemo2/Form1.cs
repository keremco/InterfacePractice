using InterfacesDemo2.Services;
using InterfacesDemo2.Services.Bases;
using System.Globalization;

namespace InterfacesDemo2
{
    public partial class Form1 : Form
    {
        IKoseliHesaplaService _koseliHesapService;
        IKosesizHesapService _kosesizHesapService;
        CultureInfo _kultur = new CultureInfo("en-US"); 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKosesizHesapla_Click(object sender, EventArgs e)
        {
            _kosesizHesapService = new DaireHesapService()
            {
                PiUzunMu = cbPi.Checked
            };

            double alan = _kosesizHesapService.AlanHesapla(Convert.ToDouble(tbYaricap.Text.Trim().Replace(",", "."), _kultur));

            double cevre = _kosesizHesapService.CevreHesapla(Convert.ToDouble(tbYaricap.Text.Trim().Replace(",", "."), _kultur));

            lSonuc.Text = $"Alan: {alan} \r\n Çevre: {cevre}";
        }

        private void btnKoseliHesapla_Click(object sender, EventArgs e)
        {
            
            if (ddlSekil.SelectedIndex == 0)
            {
                _koseliHesapService = new DikdortgenHesapService();             

            }
            else if (ddlSekil.SelectedIndex == 1)
            {
                _koseliHesapService = new DikucgenHesapService();
            }

            string taban = tbTaban.Text.Trim().Replace(",", ".");
            string yukseklik = tbYukseklik.Text.Trim().Replace(",", ".");


            double alan = _koseliHesapService.AlanHesapla(Convert.ToDouble(taban, _kultur), Convert.ToDouble(yukseklik, _kultur));
            double cevre = _koseliHesapService.CevreHesapla(Convert.ToDouble(taban, _kultur), Convert.ToDouble(yukseklik, _kultur));

            lSonuc.Text = $"Alan: {alan} \r\n Çevre: {cevre}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sekiller = new string[2]
            {
                "Dikdörtgen",
                "Dik Üçgen"
            };
            ddlSekil.DataSource = sekiller;
            ddlSekil.SelectedIndex = 0; 
        }
    }
}