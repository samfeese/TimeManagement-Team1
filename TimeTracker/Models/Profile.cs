namespace TimeTracker.Models
{
    public class Profile
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int UserId { get; set; }

        // user ID from AspNetUser table.
        public string OwnerID { get; set; }

        public string Name { get; set; }

        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}