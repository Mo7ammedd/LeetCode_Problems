public class Solution {
    int[,] dir = new int[4,2]{{-1,0},{0,1},{1,0},{0,-1}};

    public bool CheckIfWordExists(int r, int c, int pos, char[][] board, string word, bool[,] visited)
    {
        if(pos == word.Length)
            return true;

        bool tans = false;
        int m = board.Length;
        int n = board[0].Length;

        for(int i=0;i<4;i++)
        {
            if(r+dir[i,0]>=0 && c+dir[i,1]>=0 && r+dir[i,0]<m && c+dir[i,1]<n && visited[r+dir[i,0],c+dir[i,1]] == false && board[r+dir[i,0]][c+dir[i,1]] == word[pos])
            {
                visited[r+dir[i,0],c+dir[i,1]] = true;
                if(CheckIfWordExists(r+dir[i,0],c+dir[i,1],pos+1,board,word,visited))
                    tans = true;
                visited[r+dir[i,0],c+dir[i,1]] = false;
            }
        }

        return tans;
    }

    public bool Exist(char[][] board, string word)
    {
        int m = board.Length;
        int n = board[0].Length;
        bool[,] visited = new bool[m,n];

        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(board[i][j] == word[0])
                {
                    Array.Clear(visited);
                    visited[i,j] = true;
                    if(CheckIfWordExists(i,j,1,board,word,visited))
                        return true;
                }
            }
        }

        return false;
    }
}