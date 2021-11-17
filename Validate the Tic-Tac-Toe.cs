  public static bool ValidateTicTacToe(string[] board) {
    if (string.Join("", board).Count(x => x == 'O') > string.Join("", board).Count(x => x == 'X')) return false;
     int o = string.Join("", board).Count(y => y == 'O');
     int p = string.Join("", board).Count(y => y == 'X');
     if (o > p || p - o > 1 || o - p > 1) return false;      
	   bool b = false;
     for (int i = 0; i < 3; i++)
         if(board[i].Any(x=>x!=' ')&& board[i].Distinct().Count()<2)
         {
             if (b == true) return false;
             b = true;
         }
		 var a = new string[3, 3];
     int r = 0;
     for (int i = 0; i < 4; i++)
     {
         if (i == 3) { i = 0; r++; }
         if (r == 3) break;
         a[r, i] = board[r].ElementAt(i).ToString();
     }
     string t = "", s = "";
     for (int i = 0, j = 2; i < 3; i++, j--) 
     {
         t += a[i, i].ToString();
         s += a[i, j];
     }
     if (t.Replace(" ", "").Distinct().Count() < 2 || s.Replace(" ", "").Distinct().Count() < 2) return true;
     for (int i = 0; i < 3; i++)
     {
       if (string.Join("", Enumerable.Range(0, a.GetLength(1)).Select(x => a[i, x])
       .ToArray()).Where(x=>x!=' ').Distinct().Count() < 2) return true;
       else if (string.Join("", Enumerable.Range(0, a.GetLength(0)).Select(x => a[x, i])
       .ToArray()).Where(x => x != ' ').Distinct().Count() < 2) return true;
     }
		return false;
	}