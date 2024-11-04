using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FazendaUrbana.Models;

namespace FazendaUrbana.Services
{
    public class DepartmentsService
    {
        private readonly FazendaUrbanaContext _context;

        public DepartmentsService(FazendaUrbanaContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
