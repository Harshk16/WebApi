using System.Web.Mvc;
using WebApi.Core.Interfaces;
using WebApi.Core.Service;

namespace WebApi.Web.Api.Controllers
{
    public class TestController : Controller
    {
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        private readonly ITestService _testService;

        public string Index()
        {
            ITestService test = new TestService();

            var result = test.GetData(1);

            var data = test.GetAll();

            return result;
        }

        //public IEnumerable<TestDto> Index()
        //{
        //    ITestService test = new TestService();

        //    var data = test.GetAll();

        //    return (data);
        //}
    }
}