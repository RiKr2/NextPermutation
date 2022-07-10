using Microsoft.AspNetCore.Mvc;

namespace NextPermutation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NextPermutationController : ControllerBase
    {
        [HttpPost(Name = "getNextPermutation")]
        public IEnumerable<int> Get()
        {
            throw new NotImplementedException();
        }
    }
}
