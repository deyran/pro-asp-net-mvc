using System.ComponentModel.DataAnnotations;

namespace SportsStore.WebUI.Models
{
    /*
    chapter 12 - SportsStore: Security & Finishing Touches
        Securing the Administration Controller
            Creating the Account Controller 311
                Listing 12-7. The Contents of the LoginViewModel.cs File
     */
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

