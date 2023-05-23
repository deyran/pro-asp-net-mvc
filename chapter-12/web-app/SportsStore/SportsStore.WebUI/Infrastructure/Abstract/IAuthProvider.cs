
namespace SportsStore.WebUI.Infrastructure.Abstract
{
    /*
    chapter 12 - SportsStore: Security & Finishing Touches
        Securing the Administration Controller
            Creating the Authentication Provider 309
                Listing 12-4. The Contents of the IAuthProvider.cs File     
     */
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}