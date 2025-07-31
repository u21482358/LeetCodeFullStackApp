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
        public object TwoSum(int[] list1, int target)
        {
            int[] list2 = [];
            for (int i = 0; i < list1.Length - 1; i++)
            {
                for (int j = i + 1; j < list1.Length - 1; j++)
                {
                    if (list1[i] + list1[j] == target)
                    {
                        return new int[] { list1[i], list1[j] }; // need to return like this else wont pick up data https://stackoverflow.com/questions/9818187/return-an-array-without-creating-a-variable

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
