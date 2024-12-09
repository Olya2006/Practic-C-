namespace Pz1.TaskSystem.Tasks
{
    internal class Task3 : ITaskeable
    {
        private int _min;
        private int _max;

        private int[] _numbers;
        public Task3()
        {
            _min = 1;
            _max = 10 + 6;

            _numbers = new int[3];
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = new Random().Next(-50, 50);
            }
        }

        public Task3(int[] numbers, int min, int max)
        {
            _numbers = numbers;

            _min = min;
            _max = max;
        }
        public void StartTask()
        {
            StartTask(_numbers);
        }

        public void StartTask(int[] arr)
        {
            ShowArray(arr);

            PrintNumbersWithinRange(arr, _min, _max);
        }

        private void ShowArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private void PrintNumbersWithinRange(int[] numbers, int min, int max)
        {
            Console.Write($"Numbers that are in range of [{_min};{_max}]: ");

            foreach (int number in numbers)
            {
                if (IsWithinRange(number, min, max))
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine();
        }

        private bool IsWithinRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        public void StopTask()
        {
            Console.Clear();
        }
    }
}