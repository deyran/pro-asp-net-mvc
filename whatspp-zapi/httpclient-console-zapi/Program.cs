using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace httpclient_console_zapi
{
    class Program
    {
        /*
         Install these packates:
            Install-Package Microsoft.Net.Http
            Install-Package Microsoft.AspNet.WebApi.Client

         */
        static void Main(string[] args)
        {
            try
            {
                var task = new WhatsAppSend().ExecutarAsync
                (
                    new WhatsAppMessage()
                    {
                        phone = "5591984923955",
                        message = "TESTE 001"
                    }
                );

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class WhatsAppSend
    {
        public async Task ExecutarAsync(WhatsAppMessage whatsAppMessage)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(whatsAppMessage.getBaseAdress());
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await cliente.PostAsJsonAsync(whatsAppMessage.getInstance("send-text"), whatsAppMessage);

                if (response.IsSuccessStatusCode)
                {
                    //???
                }
            };
        }
    }

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
