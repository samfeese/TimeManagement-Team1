namespace TimeTracker.Models
{
    public class Profile
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}