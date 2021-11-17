 public static List<int[]> ThreeSum(int[] arr)
 {
     if (arr.Length < 3) return new List<int[]>();
     if (arr.Length == 3 && arr.Sum() == 0) return new List<int[]> { arr };
     List<int[]> list = new List<int[]>();
     for (int i = 0; i < arr.Length - 2; i++)
       for (int j = i + 1; j < arr.Length - 1; j++)
         for (int k = j + 1; k < arr.Length; k++)
           if (arr[i] + arr[j] + arr[k] == 0 )
             list.Add(new int[] { arr[i], arr[j], arr[k] });
      return list.GroupBy(c => string.Join(",", c)).Select(c => c.First().ToArray()).ToList();
 }
}