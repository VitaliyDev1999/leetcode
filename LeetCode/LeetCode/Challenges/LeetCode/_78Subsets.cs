using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.Challenges.LeetCode
{
    //ref https://leetcode.com/problems/subsets
    public static class _78Subsets
    {
        //У каждого элемента есть два состояния — включён или нет → 2^n подмножеств.
        //Мы можем представить каждое подмножество в виде бинарной маски от 0 до 2^n - 1.
        //Для nums = [1, 2, 3]:
        //000 → []
        //001 → [1]
        //010 → [2]
        //011 → [1, 2]
        //...
        //111 → [1, 2, 3]
        public static IList<IList<int>> SubsetsV3(int[] nums)
        {
            var result = new List<IList<int>>();
            int n = nums.Length;
            int total = 1 << n; // 2^n подмножеств

            for (int mask = 0; mask < total; mask++)
            {
                var subset = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    var leftShift = (1 << i);
                    var and = mask & leftShift;

                    var maskBit = Convert.ToString(mask, 2);
                    var leftShiftBit = Convert.ToString(leftShift, 2);
                    // Проверяем, включён ли i-й элемент в подмножество
                    if (and != 0)
                    {
                        subset.Add(nums[i]);
                    }
                }

                result.Add(subset);
            }

            return result;
        }

        #region Итеративное решение
        public static IList<IList<int>> SubsetsV2(int[] nums)
        {
            var result = new List<IList<int>>();
            result.Add(new List<int>()); // начинаем с пустого подмножества

            foreach (var num in nums)
            {
                int size = result.Count;

                // Копируем все текущие подмножества и добавляем в них текущий элемент
                for (int i = 0; i < size; i++)
                {
                    var newSubset = new List<int>(result[i]);
                    newSubset.Add(num);
                    result.Add(newSubset);
                }
            }

            return result;
        }
        #endregion

        #region Backtrack
        public static IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>(); // Здесь будут все подмножества
            var subset = new List<int>(); // Текущее подмножество, которое мы строим

            Backtrack(0, nums, subset, result);

            return result;
        }

        private static void Backtrack(int start, int[] nums, List<int> subset, List<IList<int>> result)
        {
            // 🔹 Добавляем копию текущего подмножества в результат
            result.Add(new List<int>(subset));

            // 🔹 Перебираем все возможные элементы, начиная с индекса `start`
            for (int i = start; i < nums.Length; i++)
            {
                // ▶ 1. Добавляем nums[i] в текущее подмножество
                subset.Add(nums[i]);

                // ▶ 2. Рекурсивно строим подмножества начиная со следующего элемента
                Backtrack(i + 1, nums, subset, result);

                // ▶ 3. Удаляем последний элемент — backtracking (откат)
                subset.RemoveAt(subset.Count - 1);
            }
        }
        #endregion
    }
}
