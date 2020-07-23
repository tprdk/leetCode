public class Solution {
    public int StrStr(string haystack, string needle) {
        int index = 0, increment = 0;
        Boolean flag  = true;
        if( haystack.Length == 0 || needle.Length == 0){
            if(haystack.Length == 0 && needle.Length != 0)
                return -1;
            return 0;
        }
        
        while ( flag && index < haystack.Length ){
            increment = 0;
            if ( haystack[ index ] == needle [ increment ]){
                while ( index + increment < haystack.Length && increment < needle.Length 
                            && haystack[ index + increment ] == needle [ increment ] )
                    increment++;
                if(increment == needle.Length)
                    flag = false;
            }
            index++;
        }
        if( flag )
            return -1;
        return index - 1;
    }
}
