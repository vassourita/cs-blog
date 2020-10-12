using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CsBlog.Domain.Entities
{
    public class TagEntity : BaseEntity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "User name is required")]
        [MaxLength(16, ErrorMessage = "Tag name must have a maximum of {1} characters")]
        public string Name { get; set; }

        public IEnumerable<PostEntity> Posts { get; set; }
    }
}