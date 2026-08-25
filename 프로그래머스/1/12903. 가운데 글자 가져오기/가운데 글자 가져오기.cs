public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] chars = s.ToCharArray();
        int mid = chars.Length / 2;
        
        if (chars.Length % 2 != 0) {
            answer = chars[mid].ToString();
        } 
        else {
            answer = chars[mid - 1].ToString() + chars[mid].ToString();
        }
        
        return answer;
    }
}