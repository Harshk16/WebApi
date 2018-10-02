using System.Collections.Generic;
using WebApi.Core.Dto;
using WebApi.Core.Interfaces;
using WebApi.Core.Model.Interfaces;
using WebApi.Core.Model.Models;

namespace WebApi.Core.Service
{
    public class TestService : ITestService
    {
        public TestService(
            IRepository<User> userRepository
            )
        {
            _userRepository = userRepository;
        }

        private readonly IRepository<User> _userRepository;
        public string GetData(int id)
        {
            return "Harsh" + " " + id;
        }

        public List<TestDto> GetAll()
        {
            List<TestDto> list = new List<TestDto>();

            list.Add(new TestDto { Id = 1, Name = "Harsh", Email = "Harsh@gmail.com", City = "Bangalore", PinCode = "560078" });

            list.Add(new TestDto { Id = 1, Name = "Sanjay", Email = "Sanjay@gmail.com", City = "Bangalore", PinCode = "560078" });

            list.Add(new TestDto { Id = 1, Name = "Ritika", Email = "Ritika@gmail.com", City = "Bangalore", PinCode = "560078" });

            list.Add(new TestDto { Id = 1, Name = "Amanda", Email = "Amanda@gmail.com", City = "Bangalore", PinCode = "560078" });

            return list;
        }

        public IEnumerable<User> Get()
        {

            var result = _userRepository.GetModels();

            return result;
        }
    }
}
