namespace CsBlog.Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public TagEntity Tag { get; set; }

        public UserEntity Author { get; set; }
    }
}