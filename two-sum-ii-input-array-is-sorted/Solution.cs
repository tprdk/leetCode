public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Boolean flag = true ; 
        int index1 = 0 , index2 = numbers.Length - 1 , sum = 0; 
        int[] index = {-1, -1};

        while ( flag ){
            sum =  numbers[index1] + numbers[index2] ;
            if( sum == target ){
                index[0] = index1 + 1;
                index[1] = index2 + 1;
                flag = false;
            }else{
                if( sum < target ){
                    index1++;
                }else{
                    index2--;
                }
            }
        }
        return index;
    }
}
