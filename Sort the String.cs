    public static string sorting(string str) 
    {
      string n=string.Concat(str.Where(x=>char.IsDigit(x)).Select(x=>x).OrderBy(x=>x));
      str=Regex.Replace(str,"[0-9]","");
      StringBuilder sb=new StringBuilder();
      for(int i=97;i<123;i++)
      {
        sb.Append(new string((char)i,str.Count(x=>(char)i==x)));
        str=str.Replace(((char)i).ToString(),"");
        if(str.Any(x=>(int)x==i-32))
        {
          sb.Append(new string((char)(i-32),str.Count(x=>(char)(i-32)==x)));
          str=str.Replace(((char)(i-32)).ToString(),"");
        }
      }
      return sb.ToString()+string.Concat(str.OrderBy(x=>x))+n;
    }