using System.ComponentModel.DataAnnotations;

namespace Frevent.Web.ViewModels.Auth
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}