using System.ComponentModel.DataAnnotations;

namespace ProteinApp.Models
{
    public class UserModel
    {
        [Required]
        public string FirstName { get; set; }


        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set;}


    }
}
