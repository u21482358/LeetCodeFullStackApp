using ResturauntViewing.Models.Models;

namespace ResturauntViewing.Models.LeetCodeMethodModels
{
    public class ListQuestions
    { // maybe put each class aligned with the operation name.
        

        public object TwoSumList(List<int> list1,int target)
        {
            List<int> list2 = new List<int>();
           for(int i=0;i< list1.Count-1; i++)
            {
                for (int j = i + 1; j < list1.Count-1; j++)
                {
                    if (list1.ElementAt(1) + list1.ElementAt(j) == target)
                    {
                        list2.AddRange([list1.ElementAt(1), list1.ElementAt(j)]);
                        return list2;
                       //
                    }
                }
                {

                }
            }

            return list2;
        }
        public object TwoSum(int[] nums, int target)
        {
            int[] list2 = [];
            for (int i = 0; i < nums.Length; i++) // made a mistake with the last index value.
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        // return new int[] { nums[i], nums[j] }; // need to return like this else wont pick up data https://stackoverflow.com/questions/9818187/return-an-array-without-creating-a-variable
                        return new int[] { i,j };
                        //
                    }
                }
                {

                }
            }

            return list2;
        }

        public int[] TwoSumSolution(int[] nums, int target) // https://leetcode.com/problems/two-sum/solutions/127810/two-sum/
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // Return an empty array if no solution is found
            return new int[] { };
        }

        public object TwoSumSorted(int[] nums, int target)
        {
            int[] list2 = [];
            for (int i = 0; i < nums.Length; i++) // made a mistake with the last index value.
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        // return new int[] { nums[i], nums[j] }; // need to return like this else wont pick up data https://stackoverflow.com/questions/9818187/return-an-array-without-creating-a-variable
                        return new int[] { i, j };
                        //
                    }
                }
                {

                }
            }

            return list2;
        }



    }
}
