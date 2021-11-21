	public static int DiamondSum(int n) 
	{
		 	 int[,] m=new int[n,n];
		 	 int x=1;
		 	 int sum=0;
		 	 int mid=n/2;
		 	 int midDiff=0;
   		 for (int i = 0; i < m.GetLength(0); i++)
			 {
        	for (int j = 0; j < m.GetLength(1); j++)
        	{
            	m[i, j] =x;
							x++;
       		 }
			 		if(i<mid)
			 		{
						 if(sum==0)
							 sum+=m[i,mid];
				 		else
							 sum+=m[i,mid-i]+m[i,mid+i];
				 		midDiff++;
			 		}
					else
			 		{
					  if(i==m.GetLength(0)-1)sum+=m[i,mid];
				    else sum+=m[i,mid-midDiff]+m[i,mid+midDiff];
				    midDiff--;
					}
		 }
		return sum;
	}