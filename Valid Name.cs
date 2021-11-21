	  public static bool ValidName(string name)
    {
        return Regex.IsMatch(name, @"^(([A-Z][a-z]+) ([A-Z][a-z]+ |[A-Z]\. )|[A-Z]\. ([A-Z]\. )?)[A-Z][a-z]+$");
    }