using System.Xml.Linq;

namespace dev_trail.Data.Entities;

public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Slug { get; set; }
    public string AuthorId { get; set; }
    public User Author { get; set; }
    public List<Comment> Comments { get; set; }
    public List<Tag> Tags { get; set; }
    public DateTime CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}
