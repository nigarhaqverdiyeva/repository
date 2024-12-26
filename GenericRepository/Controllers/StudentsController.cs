using GenericRepository.Contexts;
using GenericRepository.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }
    }
   

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Student> students = await _context.Students.ToListAsync();
        //  List<Student> students = await _context.Students.Include(s=>s.Group).ToListAsync();
        return Ok(students);
    }
    [HttpGet"ById")]
    public async Task<IActionResult> GetById(int id)
    {
        Student? student = await _context.Students.FindAsync();
        Student? student2 = await _context.Students.SingleOrDefaultAsync(s = s => s.Id == id);
        Student? student3 = await _context.Students.FirstOrDefaultAsync(s = s => s.Id == id);

        return Ok(student);

    }
}
