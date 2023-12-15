namespace webapi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;  
        public string Location { get; set; } = string.Empty;
        public required DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
