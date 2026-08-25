public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int start = 0;
        int last = 0;
        
        if(a < b) { start = a; last = b;}
        if(a > b) { start = b; last = a;}
        if(a == b) { start = a; last = a;}
        
        for(int i = start; i <= last; i++){
            answer += i;
        }
        return answer;
    }
}