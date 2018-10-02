using System.Collections.Generic;
using WebApi.Core.Dto;
using WebApi.Core.Model.Models;

namespace WebApi.Core.Interfaces
{
    public interface ITestService
    {
        string GetData(int id);

        List<TestDto> GetAll();

        IEnumerable<User> Get();
    }
}
