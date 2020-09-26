using System;

namespace PR_Test {
    class Program {
        static void Main (string[] args) {
            int[] number = {1, 4, 2, 6, 8, 3, 7, 1, 3};
            int target = 4;
            int[] results = TwoSum(number, target);

            foreach(int index in results) {
                Console.WriteLine("Indices: " + index);
            }
        }

        public static int[] TwoSum (int[] nums, int target) {
            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++) {
                for (int j = i+1; j < nums.Length; j++) {
                    if ( nums[i] + nums[j] == target) {
                        indices[0] = i;
                        indices[1] = j;
                        return indices;
                    }
                }
            }

            return indices;
        }
    }
}