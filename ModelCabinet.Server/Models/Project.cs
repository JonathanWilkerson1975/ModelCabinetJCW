using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ModelCabinet.Server.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public virtual List<Asset> Assets { get; set; }

        [RegularExpression("^[^\\s]+$")]
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        [JsonIgnore]
        public virtual ICollection<ProjectTag> Tags { get; } = new HashSet<ProjectTag>();
        [NotMapped]
        public IList<Tag> TagsList => Tags.Select(t => t.Tag).ToList();

    }
}
