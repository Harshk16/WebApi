using System.Collections;
using System.Web.Mvc;
using WebApi.Core.Interfaces;

namespace WebApi.Web.Api.Controllers
{
    public class TestController : Controller
    {
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        private readonly ITestService _testService;

        public IEnumerable Index()
        {
            //ITestService test = new TestService();

            //var result = _testService.GetData(1);

            var result = _testService.Get();


            var data = _testService.GetAll();

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