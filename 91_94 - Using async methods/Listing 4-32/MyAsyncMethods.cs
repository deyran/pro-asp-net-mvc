using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    /*
    >> USING ASYNC METHODS -> 91-94
    >>>> Listing 4-32. A simple asynchronous methods in the MyAsyncMethods.cs file - 91    
    */
    public class MyAsyncMethods
    {
        public static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpTask = client.GetAsync("http://apress.com");

            // we could do other things here while we are waiting
            // for the HTTP request to complete

            return httpTask.ContinueWith
            (
                (Task<HttpResponseMessage> antecedent) =>
                {
                    return antecedent.Result.Content.Headers.ContentLength;
                }
            );
        }
    }
}