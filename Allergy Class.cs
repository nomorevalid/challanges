using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection;
using System.Text;
public class Allergies
{
    [Flags]
    public enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }
    public string Name { get; }
    public int Score { get; private set; }
​
    public Allergies(string name) 
    {
      Name = name;
    }
    public Allergies(string name, int score)
    {
        Name = name;
        Score = score;
    }
    public Allergies(string name, string stringScore)
    {
        Name = name;
        foreach (var item in stringScore.Split(' ').ToArray())
            Score += (int)Enum.Parse(typeof(Allergen), item.ToString());
    }
  
    public bool IsAllergicTo(object allergy)
    {
        int val = (int)Enum.Parse(typeof(Allergen), allergy.ToString());
        if (allergy.GetType() == typeof(string))
            return (Score & val) == val;
        else return (Score & (int)allergy) == (int)allergy;
    }
  
    public void AddAllergy(object item)
    {
        if (item.GetType() == typeof(string))
            Score += (int)Enum.Parse(typeof(Allergen), item.ToString());
        else Score += (int)item;
    }
    public void DeleteAllergy(object item)
    {
        if (item.GetType() == typeof(string))
            Score -= (int)Enum.Parse(typeof(Allergen), item.ToString());
        else Score -= (int)item;
    }
​
    public override string ToString()
    {
        if (Score == 0)
            return Name + " has no allergies!";
        else 
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Enum.GetValues(typeof(Allergen)))
            {
                if (IsAllergicTo((int)item))
                   sb.Append(item.ToString() + ", ");
            }            
            return Name + " is allergic to " +  Regex.Replace(sb.ToString(0,sb.Length-2), @"\,([^,]*)$", " and$1")+".";
        }
    }
}