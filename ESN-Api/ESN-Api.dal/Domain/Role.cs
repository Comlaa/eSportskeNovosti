using System.Text.Json.Serialization;

namespace ESN_Api.ESN_Api.dal.Domain
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public List<UserRole>? Users { get; set; }
    }
}
