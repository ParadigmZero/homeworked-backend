using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeworkController : Controller
{
    private readonly IHomework<Homework> _homeworkRepository;

    public HomeworkController(IHomework<Homework> homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var homework = await _homeworkRepository.GetAll();
            return Ok(homework);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task Insert([FromBody] Homework homework)
    {
        try
        {
            await _homeworkRepository.Insert(homework);
            // return all homework after posting a new piece of homework
            var homework = await _homeworkRepository.GetAll();
            return Ok(homework);

        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
        }
    }

    [HttpPut("{id}")]
    public async Task Update(long id, [FromBody] Child child)
    {
        try
        {
            await _homeworkRepository.Update(id, child.Id, child.Image, child.Comment, child.Annotation);
            var homework = await _homeworkRepository.GetAll();
            return Ok(homework);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
        }
    }
}
