using Microsoft.AspNetCore.Mvc;
using NextPermutation.Services;

namespace NextPermutation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NextPermutationController : ControllerBase
    {
        [HttpPost(Name = "getNextPermutation")]
        public IEnumerable<int> GetNextPermutation(int[] numbers)
        {
            NextPermutationService _service = new NextPermutationService();

            return _service.GetNextPermutation(numbers);
        }
    }
}
