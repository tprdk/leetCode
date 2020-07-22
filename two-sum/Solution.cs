public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] array = {0, 0};
        int i = 0;
        Boolean flag = true;
        Dictionary<int, int> complementMap = new Dictionary<int, int>();

        while (flag){
            if(complementMap.ContainsKey(nums[i])){
                array[0] = complementMap[nums[i]];
                array[1] = i;
                flag = false;
            }else{
                if(!complementMap.ContainsKey(target - nums[i]))
                    complementMap.Add(target - nums[i], i);
                i++;
            }
        }
        return array;
    }
}
