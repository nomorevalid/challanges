	public static string[] BinaryClock(string time)
	{
		   string[,] multi = new string[,]
        {
            {" ","0"," ","0"," ","0" },
            {" ","0","0","0","0","0" },
            {"0","0","0","0","0","0" },
            {"0","0","0","0","0","0" },
        };
        time = time.Replace(":", "");
        int x = 1;
        int y = 0;
        bool control = false;
        StringBuilder sb = new StringBuilder();
        List<string> returnList = new List<string>();
        string temp= Convert.ToString(int.Parse(time[y].ToString()), 2);
        string temp2 = string.Concat(multi[0, 0], multi[1, 0], multi[2, 0], multi[3, 0]);
        temp2 = temp2.Substring(0, temp2.Length - temp.Length) + temp;
        for (int j = 0; j < 4; j+=x)
        {
            if (control)
            { j = 0; x = 1; control = false; }
            for (int k = y; k < y+1; k++)
                if (multi[j, k] != temp2[j].ToString())
                    multi[j, k] = temp2[j].ToString();
            if (j == 3)
            {
                y++; x = 0; control = true;
                if (y == 6) break;
                temp = Convert.ToString(int.Parse(time[y].ToString()), 2);
                temp2 = string.Concat(multi[0, y], multi[1, y], multi[2, y], multi[3, y]);
                temp2 = temp2.Substring(0, temp2.Length - temp.Length) + temp;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int m = 0; m < 6; m++)
                sb.Append(multi[i, m]);
            returnList.Add(sb.ToString());
            sb.Clear();
        }
        return returnList.ToArray();
	}