namespace LeetCode.Challenges.EverythingElse.AlgoApproachesExamples.BinarySearch
{

    /*Важные моменты
     * Массив должен быть отсортирован.
     * Для избежания переполнения вычисления mid делают как left + (right - left)/2.
     * При работе с условиями поиска первого или последнего вхождения меняется обновление границ left и right.
     * Иногда используется рекурсивная версия Binary Search.*/

    /*Применение Binary Search
     * Поиск элемента в отсортированном массиве
     * Поиск по диапазонам, например:
     * Первая позиция, где значение >= target
     * Последняя позиция, где значение <= target
     * Оптимизация параметров(поиск минимального/максимального возможного решения)
     * Использование в различных задачах на интервалы, строки, массивы*/

    //Сложность O(log n)
    public class BinarySearch
    {
        public int BinarySearchMethod(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // элемент не найден
        }
    }
}
