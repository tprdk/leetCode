public class Solution {
    public IList<string> GenerateParenthesis(int n) {
            IList<string> allParenthesis = new List<string>();
            createParenthesis(allParenthesis, n, 0, 0, "");
            return allParenthesis;
        }
        
        public void createParenthesis(IList<string> allParenthesis, int count, int openParenthesis, int closeParenthesis, string parenthesis){
            if(openParenthesis + closeParenthesis == count * 2)
                allParenthesis.Add(parenthesis.ToString());
            if(openParenthesis < count)
                createParenthesis(allParenthesis, count, openParenthesis + 1, closeParenthesis, parenthesis + "(");
            if(closeParenthesis < openParenthesis)
                createParenthesis(allParenthesis, count, openParenthesis, closeParenthesis + 1, parenthesis + ")");    
        }
}
