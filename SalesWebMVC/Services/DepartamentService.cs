using SalesWebMVC.Data;
using SalesWebMVC.Models;
namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCContext _context;
        public DepartamentService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
