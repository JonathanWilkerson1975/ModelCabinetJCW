using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelCabinet.Server.Models
{
    public class ProjectTag
    {
        [Key]
        public int ProjectTagId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public ICollection<Tag> Tags { get; set; } = [];
    }
}
