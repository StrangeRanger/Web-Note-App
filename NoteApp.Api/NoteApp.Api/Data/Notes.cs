namespace NoteApp.Api.Data;

public class Notes
{
    public int NoteId { get; set; }
    public required string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime Created { get; set; }
    public DateTime LastModified { get; set; }
    public string Username { get; set; } = null!;
    public string AppUserId { get; set; } = null!;
    // public AppUser AppUser { get; set; } = null!;
}
