public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int rowCount = arr1.GetLength(0);
        int colCount = arr1.GetLength(1);
        int[,] answer = new int[rowCount, colCount];
        
        for(int i = 0; i < rowCount; i++)
        {
            for(int j = 0; j < colCount; j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        
        return answer;
    }
}