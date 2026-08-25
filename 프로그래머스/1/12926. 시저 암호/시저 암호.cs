public class Solution {
    public string solution(string s, int n) {
        char[] chars = s.ToCharArray();
        string answer = "";

        for(int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            if (c >= 'A' && c <= 'Z') 
            {
                answer += (char)('A' + (c - 'A' + n) % 26);
            }
            else if (c >= 'a' && c <= 'z') 
            {
                answer += (char)('a' + (c - 'a' + n) % 26);
            }
            else 
            {
                answer += c;
            }
        }
        return answer;
    }
}