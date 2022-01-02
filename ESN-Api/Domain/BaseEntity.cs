namespace ESN_Api.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifedAt { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            ModifedAt = CreatedAt;
        }
    }
}
