using System.Collections.Generic;
using WebApi.Core.Dto;

namespace WebApi.Core.Interfaces
{
    public interface ITestService
    {
        string GetData(int id);

        List<TestDto> GetAll();
    }
}
