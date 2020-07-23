public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> allParenthesis = new List<string>();
        createParenthesis(allParenthesis, n, 0, new char[2 * n]);
        return allParenthesis;
    }
    public Boolean isValid(char[] parenthesis){
        Stack<char> stack = new Stack<char>();
        Boolean flag = true;
        int i = 0;
        while( flag && i < parenthesis.Length){
            if( parenthesis[i] == ')' && stack.Count > 0)
                stack.Pop();
            else if(parenthesis[i] == '(')
                stack.Push('0');
            else
                flag = false;
            i++;
        }
        if(flag && stack.Count == 0)
            return true;
        return false;    
    }

    public void createParenthesis(IList<string> allParenthesis, int n, int position, char[] parenthesis){
        if(position == 2 * n){
            if( isValid (parenthesis) ){
                allParenthesis.Add(new string(parenthesis));
            }
        }
        else{
            parenthesis[position] = '(';
            createParenthesis(allParenthesis, n, position + 1, parenthesis);
            parenthesis[position] = ')';
            createParenthesis(allParenthesis, n, position + 1, parenthesis);
        }
    }
}
