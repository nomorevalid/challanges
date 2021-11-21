		public static int Soroban(string[] frame)
		{
			 int r = int.Parse(frame[1].Replace("O", "5").Replace("|", "0"));
       for (int i = 4; i < frame.Length; i++)
           r += int.Parse(frame[i].Replace("|", (i - 3).ToString()).Replace("O", "0"));
       return r;
		}