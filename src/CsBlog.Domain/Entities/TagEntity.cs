using System.Collections.Generic;

namespace CsBlog.Domain.Entities
{
    public class TagEntity : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<PostEntity> Posts { get; set; }
    }
}