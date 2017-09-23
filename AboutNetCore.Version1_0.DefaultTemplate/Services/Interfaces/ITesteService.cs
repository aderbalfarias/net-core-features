using System.Collections.Generic;
using AboutNetCore.Version1_0.DefaultTemplate.Models;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces
{
    public interface ITesteService
    {
        IEnumerable<Test> GetAll();
    }
}