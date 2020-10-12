using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CsBlog.Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        [MaxLength(40, ErrorMessage = "Post title must have a maximum of {1} characters")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Post content is required")]
        public string Content { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tag is required")]
        [MinLength(1, ErrorMessage = "Posts must have a minimum of {1} tag")]
        [MaxLength(5, ErrorMessage = "Posts must have a maximum of {1} tags")]
        public IEnumerable<TagEntity> Tags { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Post author is required")]
        public UserEntity Author { get; set; }
    }
}