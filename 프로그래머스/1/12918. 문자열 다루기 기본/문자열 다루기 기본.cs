public class Solution {
    public bool solution(string s) {
        bool answer = true;
        answer = s.Length == 4 || s.Length == 6 ? true : false;

        for(int i = 0; i < s.Length; i++)
        {
            if(!char.IsDigit(s[i])) return false;
        }
        return answer;
    }
}