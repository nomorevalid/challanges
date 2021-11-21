		static Dictionary<string, float> prices = new Dictionary<string, float>()
		{
			{ "Strawberries", 1.5f },{ "Banana", 0.5f },
			{ "Mango", 2.5f },{ "Blueberries", 1f },
			{ "Raspberries", 1f },{ "Apple", 1.75f },{ "Pineapple", 3.5f }
		};
		public Smoothies(string[] array) { Ingredients=array; }
		public string[] Ingredients{get;set;}
		public string GetCost()
		{
			float sum=0;
			for(int i=0;i<Ingredients.Length;i++)
			{ foreach(var item in prices){
				if(item.Key==Ingredients[i]){ 
						sum+=item.Value; break;} } } 
			return "£"+ sum.ToString("0.00");
		}
		public string GetPrice()=>"£"+Math.Round((float.Parse(GetCost().Remove(0,1))+float.Parse(GetCost().Remove(0,1))*1.5f),2).ToString("0.00");
		public string GetName()
		{
			if(Ingredients.Length==1)
				return Ingredients[0].Contains("rries")?Ingredients[0].Replace
				("rries","rry")+" Smoothie":Ingredients[0]+" Smoothie";
			string[] array=new string[Ingredients.Length];
			for(int i=0;i<Ingredients.Length;i++)
			{
				if(Ingredients[i].Contains("rries"))
					array[i]=Ingredients[i].Replace("rries","rry")+" ";
				else array[i]=Ingredients[i]+" ";
			}
		  Array.Sort(array);
			return string.Join("",array)+"Fusion";
		}