namespace GridFSCreateEditAndDisplay.Models
{
    public class Image
    { 
        public string ImageName { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; } 
    }
}
