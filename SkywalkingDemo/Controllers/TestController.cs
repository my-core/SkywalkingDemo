using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SkywalkingDemo.Model;
using SkywalkingDemo.Repository;

namespace SkywalkingDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;
        private readonly TestRepository _testRepository;

        public TestController(ILogger<TestController> logger,TestRepository testRepository)
        {
            _logger = logger;
            _testRepository = testRepository;
        }

        [HttpGet]
        public string Get()
        {
            //var list=_testRepository.GetList<AdminInfo>();
            var list = _testRepository.GetList<TaskJobInfo>();
            return JsonConvert.SerializeObject(list);

        }
    }
}
