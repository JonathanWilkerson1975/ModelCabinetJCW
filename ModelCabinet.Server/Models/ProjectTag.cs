using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelCabinet.Server.Models
{
    [PrimaryKey(nameof(ProjectId), nameof(TagId))]
    public class ProjectTag
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int TagId { get; set; }
        public Tag Tag { get; set; } = null!;
    }
}
