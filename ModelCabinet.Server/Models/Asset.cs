using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
