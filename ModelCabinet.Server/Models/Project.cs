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
        public List<Asset> Assets { get; set; }

        //Maybe add at a later date
        //public string Slug { get; set; }
        public string shortDescription { get; set; }

    }
}
