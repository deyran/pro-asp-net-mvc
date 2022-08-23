using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace whatsApp_api_zpai.Models
{
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
}