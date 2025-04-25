public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int,HashSet<int>>();
        var cols = new Dictionary<int,HashSet<int>>();
        var boxes = new Dictionary<(int,int),HashSet<int>>();

        for(int i = 0; i < board.Length; i++){
            for(int j = 0; j < board[0].Length; j++){
                if((rows.ContainsKey(i) && rows[i].Contains(board[i][j])) ||
                   (cols.ContainsKey(j) && cols[j].Contains(board[i][j])) ||
                   (boxes.ContainsKey((i/3,j/3)) && boxes[(i/3,j/3)].Contains(board[i][j])))
                    return false;
                if(!rows.ContainsKey(i))
                    rows[i] = new HashSet<int>();
                if(!cols.ContainsKey(j))
                    cols[j] = new HashSet<int>();
                if(!boxes.ContainsKey((i/3,j/3)))
                    boxes[(i/3,j/3)] = new HashSet<int>();
                if(board[i][j] != '.'){
                    rows[i].Add(board[i][j]);
                    cols[j].Add(board[i][j]);
                    boxes[(i/3,j/3)].Add(board[i][j]);
                }
            }
        }
        return true; 
    }
}