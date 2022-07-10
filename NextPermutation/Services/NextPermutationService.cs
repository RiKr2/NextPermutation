namespace NextPermutation.Services
{
    public class NextPermutationService
    {
        private int[] _numbers;
        public NextPermutationService(int[] numbers)
        {
            _numbers = numbers;
        }

        /// <summary>
        /// Get the next permutation of the array
        /// 
        /// Example:
        /// [1, 2, 3] -> [1, 3, 2]
        /// </summary>
        /// <returns>
        /// The next permutation of the array
        /// </returns>
        public int[] GetNextPermutation()
        {
            for (int i = _numbers.Length - 1; i >= 1; i--)
            {
                if (_numbers[i - 1] < _numbers[i]) // Searching first decrecing element from end to front in array
                {
                    for (int j = _numbers.Length - 1; j >= i - 1; j--)
                    {
                        if (_numbers[j] > _numbers[i - 1]) // Searching first element greater than found from end to front in array
                        {
                            Swap(_numbers, i - 1, j); // Swapping numbers
                            Reverse(_numbers, i); // Reverse the rest of the elements in array
                            return _numbers;
                        }
                    }
                }
            }
            // if not found the array is in decrecing order
            // then the next permutation is the array in ascending order
            Reverse(_numbers, 0);
            return _numbers;
        }

        /// <summary>
        /// Reverse an array from start param to end of array
        /// </summary>
        /// <param name="arr">Array to process</param>
        /// <param name="start">Start index to reverse</param>
        private void Reverse(int[] arr, int start)
        {
            int i = start;
            int j = arr.Length - 1;
            while (i < j)
            {
                Swap(arr, i, j);
                i++;
                j--;
            }
        }

        /// <summary>
        /// Swap elements in array
        /// </summary>
        /// <param name="arr">Array of elements</param>
        /// <param name="i">First element to swap</param>
        /// <param name="j">Second element to swap</param>
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
