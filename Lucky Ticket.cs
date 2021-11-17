    public static long LuckyTicket(int n)
    {
   	long total=0;
	for(int i=0;i<=n/2*9;i++)
	  total+=Step1(n/2,i);
	return total;
    }
    static int Step2(int num, int sum) 
    { 
        if (num == 0) 
        return sum == 0 ? 1 : 0;  
        if (sum == 0) 
        return 1; 

        int returnVal = 0; 

        for (int i = 0; i <= 9; i++) 
     	   if (sum - i >= 0)
            returnVal += Step2(num - 1,sum-i);
		
        return returnVal; 
    } 
    static long Step1(int num, int sum) 
    { 
        long returnVal = 0; 

        for (int i = 0; i <= 9; i++) 
        	if (sum - i >= 0) 
           	returnVal += Step2(num - 1, sum-i);
		
        return returnVal * returnVal;
    } 