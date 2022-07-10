namespace NextPermutation.Services
{
    public class NextPermutationService
    {
        private int[] _numbers;
        public NextPermutationService(int[] numbers)
        {
            _numbers = numbers;
        }

        public int[] GetNextPermutation()
        {
            for (int i = _numbers.Length - 1; i >= 1; i--)
            {
                if (_numbers[i - 1] < _numbers[i]) // Buscando primer elemento decreciente
                {
                    for (int j = _numbers.Length - 1; j >= i - 1; j--)
                    {
                        if (_numbers[j] > _numbers[i - 1]) // Buscando el primer elemento que sea mayor que el elemento encontrado
                        {
                            Swap(_numbers, i - 1, j); // Intercambiando numeros
                            Reverse(_numbers, j); // Poniendo en orden inverso los elementos restantes
                            return _numbers;
                        }
                    }
                }
            }
            Reverse(_numbers, 0); // Si no se encuentra es pq esta ordenado descendentemente, entonces la proxima permutacion es el array ordenado ascendentemente
            return _numbers;
        }

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

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
