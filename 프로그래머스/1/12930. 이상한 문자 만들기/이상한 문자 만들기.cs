public class Solution {
    public string solution(string s) {
        char[] c = s.ToCharArray();
        int wordIndex = 0; 

        for (int i = 0; i < c.Length; i++) {
            if (c[i] == ' ') {
                wordIndex = 0; 
                continue;
            }

            if (wordIndex % 2 == 0) {
                if (c[i] >= 'a' && c[i] <= 'z') {
                    c[i] = (char)(c[i] - 32);
                }
            } 
            else {
                if (c[i] >= 'A' && c[i] <= 'Z') {
                    c[i] = (char)(c[i] + 32);
                }
            }

            wordIndex++; 
        }

        return new string(c); 
    }
}