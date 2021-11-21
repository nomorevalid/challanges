	public static bool IsMagicSquare(int[][] arr)
	{
     for (int i = 0; i < arr.GetLength(0) - 1; i++)
         if (arr[i].Sum() != arr[i + 1].Sum()) return false;
     int s = 0, r = 0, t = 0;
     List<int> l = new List<int>(); 
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         while (r < arr.GetLength(0))
         {
             s += arr[r][t];r++;
         }
         if (l.Count > 0 && l[0] != s) return false;
         l.Add(s);s = 0; r = 0; t++;
     }
     l.Clear();
     r = arr.GetLength(0)-1; t = 0;s = 0;
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         s += arr[i][t];t++;
         l.Add(arr[i][r]); r--;
     }
     return s==l.Sum();
  }	