	public static string MaxOccur(string text)
	{
    Dictionary<char, int> d = text.GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
    bool c = d.Values.Distinct().Count() == 1;
    if (c) return "No Repetition";
    d= d.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
    List<char> s = new List<char>();
    foreach (var item in d)
        if (item.Value == d.ElementAt(0).Value)
            s.Add(item.Key);
    return string.Join(", ", s);
	}