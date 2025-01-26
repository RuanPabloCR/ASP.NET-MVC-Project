using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCContext _context;
        public DepartamentService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
