using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    /*
    >> USING ASYNC METHODS -> 91-94
    >>>> APPLYING THE ASYNC AND AWAIT KEYWORDS -> 93
    >>>>>>>> Listing 4-33. Using the async and await keywords in the MyAsyncMethods.cs file - 93
    */
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpTask = await client.GetAsync("http://apress.com");

            // we could do other things here while we are waiting
            // for the HTTP request to complete

            return httpMessage.Content.Headers.ContentLength;
            
        }
    }
}