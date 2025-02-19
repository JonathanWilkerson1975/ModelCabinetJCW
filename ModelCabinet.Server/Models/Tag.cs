using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text.Json.Serialization;

namespace ModelCabinet.Server.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }

        // Custom Tag Color (:
        [Column(TypeName = "char(6)")]
        public string Color { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProjectTag> ProjectTags { get; } = new HashSet<ProjectTag>();
        [NotMapped]
        public IList<Project> ProjectTagsList => ProjectTags.Select(t => t.Project).ToList();
        [JsonIgnore]
        public virtual ICollection<AssetTag> AssetTags { get; } = new HashSet<AssetTag>();
        [NotMapped]
        public IList<Asset> AssetTagsList => AssetTags.Select(t => t.Asset).ToList();
    }
}
