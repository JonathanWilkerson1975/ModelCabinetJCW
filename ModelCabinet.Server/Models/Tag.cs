using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelCabinet.Server.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }
        public ICollection<AssetTag> AssetTags { get; set; }
        public ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
