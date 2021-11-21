    public static int License(string me, int agents, string others) {
	  var a = (me + " " + others).Split(' ').ToList();
    a.Sort();
    int pos = a.FindIndex(x => x == me) + 1;
    if (pos <= agents) return 20;
    return (pos - agents +1) * 20;
	}	