using NextPermutation.Services;

namespace NextPermutation.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] initial_array = { 1, 2, 3 };
            int[] result_array = { 1, 3, 2 };
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            Assert.That(nextPermutationService.GetNextPermutation(), Is.EqualTo(result_array));
        }

        [Test]
        public void Test2()
        {
            int[] initial_array = { 3, 2, 1 };
            int[] result_array = { 1, 2, 3 };
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            Assert.That(nextPermutationService.GetNextPermutation(), Is.EqualTo(result_array));
        }

        [Test]
        public void Test3()
        {
            int[] initial_array = { 1, 1, 5 };
            int[] result_array = { 1, 5, 1 };
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            Assert.That(nextPermutationService.GetNextPermutation(), Is.EqualTo(result_array));
        }

        [Test]
        public void Test4()
        {
            int[] initial_array = { 1, 2, 3, 1, 2, 3 };
            int[] result_array = { 1, 2, 3, 1, 3, 2 };
            int[] result_array2 = { 1, 2, 3, 2, 1, 3 };
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            Assert.That(nextPermutationService.GetNextPermutation(), Is.EqualTo(result_array));

            NextPermutationService nextPermutationService2 = new NextPermutationService(result_array);
            Assert.That(nextPermutationService2.GetNextPermutation(), Is.EqualTo(result_array2));
        }

        [Test]
        public void Test5()
        {
            int[] initial_array = { 1 };
            int[] result_array = { 1 };
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            Assert.That(nextPermutationService.GetNextPermutation(), Is.EqualTo(result_array));
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
            NextPermutationService nextPermutationService = new NextPermutationService(initial_array);
            int[] result = nextPermutationService.GetNextPermutation();
            Assert.That(result, Is.EqualTo(result_array));

            nextPermutationService = new NextPermutationService(result);
            int[] result2 = nextPermutationService.GetNextPermutation();
            Assert.That(result2, Is.EqualTo(result_array2));

            nextPermutationService = new NextPermutationService(result2);
            int[] result3 = nextPermutationService.GetNextPermutation();
            Assert.That(result3, Is.EqualTo(result_array3));

            nextPermutationService = new NextPermutationService(result3);
            int[] result4 = nextPermutationService.GetNextPermutation();
            Assert.That(result4, Is.EqualTo(result_array4));

            nextPermutationService = new NextPermutationService(result4);
            int[] result5 = nextPermutationService.GetNextPermutation();
            Assert.That(result5, Is.EqualTo(result_array5));
        }
    }
}