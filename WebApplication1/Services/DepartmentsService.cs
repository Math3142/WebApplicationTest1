using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DepartmentsService
    {
        private readonly WebApplication1Context _context;
        public DepartmentsService(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.ToList();
        }
    }
}
