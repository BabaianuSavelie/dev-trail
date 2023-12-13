using dev_trail.Data;
using dev_trail.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dev_trail.Controllers;
public class BlogController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<User> _userManager;

    public BlogController(
        ApplicationDbContext context,
        UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [Route("/{username}/{slug}")]

    public async Task<IActionResult> Post(string username, string slug)
    {
        Console.WriteLine(slug);
        var post = await _context.Posts
            .Include(p=>p.Author)
            .Include(p=>p.Comments)
            .FirstOrDefaultAsync();


        return View(post);
    }

    [HttpPost]
    public async Task<IActionResult> Comment(string postId,string comment)
    {
        var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

        var newComment = new Comment
        {
            Id = Guid.NewGuid(),
            Content = comment,
            PostId = Guid.Parse(postId),
            AuthorId = currentUser.Id.ToString(),
        };

        await _context.AddAsync(newComment);
        await _context.SaveChangesAsync();

        return Ok("Comment created succesfully");
    }
    public IActionResult AnotherAction()
    {
        return Ok("Another action from blog controller");
    }
}
