using FazendaUrbana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaUrbana.Services
{
    public class SellerService
    {
        private readonly FazendaUrbanaContext _context;

        public SellerService(FazendaUrbanaContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
