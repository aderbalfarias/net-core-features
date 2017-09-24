using AboutNetCore.Version1_0.DefaultTemplate.Data;
using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services
{
    public class TestService : ITesteService
    {
        private readonly ApplicationDbContext _context;

        public TestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Test> GetAll()
        {
            return _context.Tests.ToList();
        }

        public Test Get(int id)
        {
            return _context.Tests.FirstOrDefault(f => f.Id == id);
        }

        public void Add(Test entity)
        {
            _context.Tests.Add(entity);
            _context.SaveChanges();
        }
    }
}
