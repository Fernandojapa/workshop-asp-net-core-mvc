using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FazendaUrbana.Models;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbana.Services
{
    public class DepartmentsService
    {
        private readonly FazendaUrbanaContext _context;

        public DepartmentsService(FazendaUrbanaContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
