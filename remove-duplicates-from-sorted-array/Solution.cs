public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int size = 0;
        for ( int i = 1 ;  i < nums.Length ; i++){
            if( nums[ i ] == nums[ i-1 ])
                size++;
            else
                nums[i - size] = nums[i];
        }
        return nums.Length - size;
    }
}
