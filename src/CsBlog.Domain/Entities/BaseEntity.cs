using System;

namespace CsBlog.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        private DateTime? _CreatedAt { get; set; }

        public DateTime? CreatedAt
        {
            get { return _CreatedAt; }
            set { _CreatedAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdatedAt { get; set; }
    }
}