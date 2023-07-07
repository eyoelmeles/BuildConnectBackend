namespace BuildConnectBackend.DTO
{
    public record Credentials(string Username, string Password);
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}