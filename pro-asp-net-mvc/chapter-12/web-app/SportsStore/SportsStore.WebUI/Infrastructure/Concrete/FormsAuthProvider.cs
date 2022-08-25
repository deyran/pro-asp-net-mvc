using System.Web.Security;
using SportsStore.WebUI.Infrastructure.Abstract;

namespace SportsStore.WebUI.Infrastructure.Concrete
{
    /*
    chapter 12 - SportsStore: Security & Finishing Touches
        Securing the Administration Controller
            Creating the Authentication Provider 309
                Listing 12-5. The Contents of the FormsAuthProvider.cs File
     */

    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}