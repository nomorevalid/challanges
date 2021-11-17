  public static int Solve(int[] boxes)
  {
			int n=	boxes.Length;
		  int[,] mul = new int[n, n];
      for (int i = 0; i < n ; i++)
      {
          mul[i, i] = boxes[i];
          if (i != n - 1)
              mul[i, i + 1] = (boxes[i] > boxes[i + 1]) ? boxes[i] : boxes[i + 1];
      }
      for (int i = 2; i < n; i++)
          for (int j = 0, k = i; k < n; j++, k++)
              mul[j, k] = Math.Max(boxes[j] + Math.Min(mul[j + 2, k], mul[j + 1, k - 1]), boxes[k] + Math.Min(mul[j + 1, k - 1], mul[j, k - 2]));
      return mul[0, n - 1] * 2 - boxes.Sum();
  }