public static string IncrementString(string txt) =>Regex.Replace(txt, "[^0-9]", "")==""?txt+1.ToString():Regex.Replace(txt, "[0-9]", "")+(int.Parse(Regex.Replace(txt, "[^0-9]", ""))+1).ToString("D"+Regex.Replace(txt, "[^0-9]", "").Length);