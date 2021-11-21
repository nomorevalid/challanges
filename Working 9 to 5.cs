	public static string OverTime(double[] arr)
	{
    		if (arr[0] >= 17) return string.Format("${0:N2}",(arr[1] - arr[0]) * (arr[2] * arr[3]));
    		double m = arr[1] > 17 ? arr[1] - 17  : 0;
    		return string.Format("${0:N2}", ((arr[1] - arr[0] - m) * arr[2] + (m > 0 ? m * (arr[2] * arr[3]) : 0)));
	}