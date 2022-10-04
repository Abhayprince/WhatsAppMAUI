namespace WhatsAppMAUI.Models
{
    public record ChatModel(string Avatar, string Name, DateTime LastMessageAt, string LastMessage, int UnreadCount)
    {
        public string LastMessageAtDisplay => $"{LastMessageAt:hh:mm}";
    }
}
