namespace whatsApp_api_zpai.Models
{
    public class WhatsAppMessage
    {
        private string INSTANCIA = "39F7AF7BF971B0D7FD1A0EB2445059A4";
        private string TOKEN = "CD9ECB59B6B832138028D5AB";
        private string BASE_ADRESS = "https://api.z-api.io/instances/";

        public string phone { set; get; }
        public string message { set; get; }

        public string getInstance(string service_)
        {
            return INSTANCIA + "/token/" + TOKEN + "/" + service_;
        }

        public string getBaseAdress()
        {
            return BASE_ADRESS;
        }

    }
}