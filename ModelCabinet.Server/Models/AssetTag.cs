using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelCabinet.Server.Models
{

    [PrimaryKey(nameof(AssetId), nameof(TagId))]
    public class AssetTag
    {
        public int AssetId { get; set; }
        public int TagId { get; set; }
        public Asset Asset { get; set; }
        public Tag Tag { get; set; }

    }
}
