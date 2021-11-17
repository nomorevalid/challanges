  public static string[] Unravel(string txt)
  {
		  if (!txt.Contains("|"))
     		 return new string[] { txt.Replace("[", "").Replace("]", "") };
      var array = Regex.Split(txt, @"(\[(?:.*?)\])").ToArray();
      Array.Resize(ref array, array.Length);
      var array2 = new string[array.Length][];
      for (int i = 0; i < array.Length; i++)
      {
          if (array[i].Contains("|"))
          {
              var splitArray = array[i].Replace("[", "").Replace("]", "").Split('|').ToArray();
              for (int j = 0; j < splitArray.Length; j++)
              {
                  Array.Resize(ref array2[i], splitArray.Length);
                  array2[i][j] = splitArray[j].ToString();
              }
          }
          else
          {
              array[i] = array[i].Replace("[", "").Replace("]", "");
              Array.Resize(ref array2[i], 1);
              array2[i][0] = array[i];
          }
      }
			var array3=array2.Aggregate(new[] { "" }.AsEnumerable(),
      (x, y) => x.Join(y, i => 1, i => 1, (k, j) => k.ToString() + j)).ToArray();
			Array.Sort(array3);
      return array3;
  }