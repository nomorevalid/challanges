  public static bool CannotCapture(int[,] board)
  {
  	int[] h = { 2, 1, -1, -2, -2, -1, 1, 2 }; 
 	int[] v = { 1, 2, 2, 1, -1, -2, -2, -1 }; 
      for (int k = 0; k < 8; k++)
          for (int j = 0; j < 8; j++)
              if (board[k, j] == 1)
                  for (int i = 0; i < 8; i++)
                  {
                      int x = k + h[i];
                      int y = j + v[i];
                      if (x >= 0 && y >= 0 &&
                          x < 8 && y < 8 &&
                          board[x, y] == 1)
                          return false;
                  }
      return true;
  }