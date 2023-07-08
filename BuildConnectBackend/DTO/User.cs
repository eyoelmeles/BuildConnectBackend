namespace BuildConnectBackend.DTO
{
    public record Credentials(string Username, string Password);
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}