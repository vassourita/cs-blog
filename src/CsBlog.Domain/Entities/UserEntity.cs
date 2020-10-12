using System.Collections.Generic;

namespace CsBlog.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IEnumerable<PostEntity> Posts { get; set; }
    }
}