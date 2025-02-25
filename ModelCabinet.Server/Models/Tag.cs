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

        // Custom Tag Color (Uses Hex) (:
        [Column(TypeName = "char(6)")]
        public string Color { get; set; }
    }
}
