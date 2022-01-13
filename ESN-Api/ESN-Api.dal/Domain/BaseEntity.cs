using System.Text.Json.Serialization;

namespace ESN_Api.ESN_Api.dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime ModifedAt { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            ModifedAt = CreatedAt;
        }
    }
}
