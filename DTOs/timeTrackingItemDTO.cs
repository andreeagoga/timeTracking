namespace timeTracking.DTOs
{
    public class TimeTrackingItemDTO
    {   
        public long Id { get; set;}
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public int NumarOre { get; set; }
    }
}