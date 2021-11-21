	public static string SpecialReverseString(string txt)
	{
		var str=txt.ToLower().Replace(" ","").ToCharArray().Reverse().ToList();
		for(int i=0;i<txt.Length;i++)
		{
			if(char.IsWhiteSpace(txt[i]))str.Insert(i,' ');
			if(char.IsUpper(txt[i]))str[i]=char.ToUpper(str[i]);
		}
		return string.Join("",str);
	}