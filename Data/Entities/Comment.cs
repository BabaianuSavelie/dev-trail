namespace dev_trail.Data.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public Guid PostId { get; set; }
    public string AuthorId { get; set; }
    public User Author { get; set; }
}
