using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelCabinet.Server.Models
{
    public class AssetTag
    {
        [Key]
        public int AssetTagId { get; set; }
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public ICollection<Tag> Tag { get; set; } = [];
    }
}
