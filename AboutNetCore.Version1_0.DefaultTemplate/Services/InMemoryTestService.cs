using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services
{
    public class InMemoryTestService : ITesteService
    {
        private readonly List<Test> _testList;

        public InMemoryTestService()
        {
            _testList = new List<Test>
            {
                new Test{ Id = 1, Name = "Teste 1"},
                new Test{ Id = 2, Name = "Teste 2"},
                new Test{ Id = 3, Name = "Teste 3"},
                new Test{ Id = 4, Name = "Teste 4"},
                new Test{ Id = 5, Name = "Teste 5"},
                new Test{ Id = 6, Name = "Teste 6"}
            };
        }

        public IEnumerable<Test> GetAll()
        {
            return _testList.ToList();
        }
    }
}
