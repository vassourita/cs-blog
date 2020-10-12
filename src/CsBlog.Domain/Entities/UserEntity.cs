using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CsBlog.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "User name is required")]
        [MaxLength(60, ErrorMessage = "User name must have a maximum of {1} characters")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User email is required")]
        [MaxLength(120, ErrorMessage = "User email must have a maximum of {1} characters")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User password is required")]
        public string Password { get; set; }

        public IEnumerable<PostEntity> Posts { get; set; }
    }
}