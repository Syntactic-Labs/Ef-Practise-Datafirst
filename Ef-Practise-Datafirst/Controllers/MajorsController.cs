using Ef_Practise_Datafirst.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Practise_Datafirst.Controllers
{
    public class MajorsController
    {
        private readonly EdDbContext _context;
        
        public MajorsController()
        {
            _context = new EdDbContext();
        }

        public async Task<List<Major>> GetAll()
        {
            return await _context.Majors.ToListAsync();
        }
        public async Task<Major> GetByPk(int Id)
        {
            return await _context.Majors.FindAsync(Id);
        }
        public Major GetByCode(string Code)
        {
            return _context.Majors.SingleOrDefault(m => m.Code == Code);
        }
    
    }
    
}
