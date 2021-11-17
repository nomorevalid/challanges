	public static string WhatsTheTime(string bitmap)
	{
      List<int> binary = new List<int>() { 31599, 11415, 29671, 29647, 23497, 31183, 18927, 29257, 31727, 31689 };
      List<string> array = new List<string>();
      for (int i = 0; i < 5; i++)
          array.Add(bitmap.Substring(i * 17, 17));
      string s1 = "", s2 = "", s3 = "", s4 = "";
      for (int i = 0; i < array.Count; i++)
      {
          s1 += array[i].Substring(0, 3);
          s2 += array[i].Substring(4, 3);
          s3 += array[i].Substring(10, 3);
          s4 += array[i].Substring(14, 3);
      }
      return string.Concat(binary.FindIndex(i => i == Convert.ToInt32(s1, 2)), binary.FindIndex(i => i == Convert.ToInt32(s2, 2)), ":"
          , binary.FindIndex(i => i == Convert.ToInt32(s3, 2)), binary.FindIndex(i => i == Convert.ToInt32(s4, 2)));
	}