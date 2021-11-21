 public static string TapCode(string text)
 {
     bool check = text[0] == '.';
     Dictionary<char, string> d = new Dictionary<char, string>()
     { {'a',". ."},{'b',". .."},{'c',". ..."},{'k',". ..."},{'d',". ...."},
       {'e',". ....."},{'f',".. ."},{'g',".. .."},{'h',".. ..."},
       {'i',".. ...."},{'j',".. ....."},{'l',"... ."},{'m',"... .."},
       {'n',"... ..."},{'o',"... ...."},{'p',"... ....."},{'q',".... ."},
       {'r',".... .."},{'s',".... ..."},{'t',".... ...."},{'u',".... ....."},
       {'v',"..... ."},{'w',"..... .."},{'x',"..... ..."},{'y',"..... ...."},
       {'z',"..... ....."}
     };
     StringBuilder sb = new StringBuilder();
     if (!check)
     {
        foreach (var item in text)
            foreach (var item2 in d)
                if (item == item2.Key)
                {
                    sb.Append(item2.Value+" ");
                    break;
                }
         return sb.ToString().TrimEnd();
     }
     else
     {
         var l = Regex.Matches(text, @"(.+? .+?) ").Cast<Match>().Select(m => m.Value.TrimEnd()).ToList();
         l.Add(Regex.Replace(text, @"(.+? .+?) ", ""));
         foreach (var item in l)
             foreach (var item2 in d)
                 if (item2.Value == item)
                 {
                     sb.Append(item2.Key);
                     break;
                 }
         return sb.ToString();
     }
 }