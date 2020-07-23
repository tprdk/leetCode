public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int first = 0, last = nums.Length - 1, size = 0;

        while( first <= last ){
            if( nums[last] == val ){
                last--;
                size++;
            }
            else if( nums[first] == val ){
                nums[first] = nums[last];
                size++;
                last--;
            }
            else
                first++;  
        }
        return nums.Length - size;
    }
}
