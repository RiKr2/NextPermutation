using NextPermutation.Services;

namespace NextPermutation.Test
{
    public class Tests
    {
        NextPermutationService _nextPermutationService;

        [SetUp]
        public void Setup()
        {
            _nextPermutationService = new NextPermutationService();
        }

        [Test]
        public void Test1()
        {
            int[] initial_array = { 1, 2, 3 };
            int[] result_array = { 1, 3, 2 };
            
            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));
        }

        [Test]
        public void Test2()
        {
            int[] initial_array = { 3, 2, 1 };
            int[] result_array = { 1, 2, 3 };

            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));
        }

        [Test]
        public void Test3()
        {
            int[] initial_array = { 1, 1, 5 };
            int[] result_array = { 1, 5, 1 };

            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));
        }

        [Test]
        public void Test4()
        {
            int[] initial_array = { 1, 2, 3, 1, 2, 3 };
            int[] result_array = { 1, 2, 3, 1, 3, 2 };
            int[] result_array2 = { 1, 2, 3, 2, 1, 3 };
            
            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));

            Assert.That(_nextPermutationService.GetNextPermutation(result_array), Is.EqualTo(result_array2));
        }

        [Test]
        public void Test5()
        {
            int[] initial_array = { 1 };
            int[] result_array = { 1 };

            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));
        }

        [Test]
        public void Test6()
        {
            int[] initial_array = { 0, 1, 15, 20, 80, 100 };
            int[] result_array = { 0, 1, 15, 20, 100, 80 };
            int[] result_array2 = { 0, 1, 15, 80, 20, 100 };
            int[] result_array3 = { 0, 1, 15, 80, 100, 20 };
            int[] result_array4 = { 0, 1, 15, 100, 20, 80 };
            int[] result_array5 = { 0, 1, 15, 100, 80, 20 };

            Assert.That(_nextPermutationService.GetNextPermutation(initial_array), Is.EqualTo(result_array));

            Assert.That(_nextPermutationService.GetNextPermutation(result_array), Is.EqualTo(result_array2));

            Assert.That(_nextPermutationService.GetNextPermutation(result_array2), Is.EqualTo(result_array3));

            Assert.That(_nextPermutationService.GetNextPermutation(result_array3), Is.EqualTo(result_array4));

            Assert.That(_nextPermutationService.GetNextPermutation(result_array4), Is.EqualTo(result_array5));
        }
    }
}