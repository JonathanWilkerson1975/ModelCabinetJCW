using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ModelCabinet.Server.Models
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateUpdated { get; set; }
        public long FileSize { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [JsonIgnore]
        public virtual ICollection<AssetTag> Tags { get; } = new HashSet<AssetTag>();
        [NotMapped]
        public IList<Tag> TagsList => Tags.Select(t => t.Tag).ToList();
    }
}
