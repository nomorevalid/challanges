		public static string[] SortContacts(string[] names, string sort)
		{
      		 if (names == null || names.Length == 0) return new string[0];
      		 if (names.Length == 1) return names;
      		 return sort == "ASC" ? names.OrderBy(x => x.Substring(x.IndexOf(" ") + 1)).ToArray() :
         	   names.OrderByDescending(x => x.Substring(x.IndexOf(" ") + 1)).ToArray();
		}