namespace dev_trail.Data.Entities;

public class Tag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Post> Posts { get; set; }
    public DateTime CreatedAt { get; set; }
}
