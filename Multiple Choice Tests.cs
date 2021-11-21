	public interface ITestpaper
  {
      string Subject { get; }
      string[] MarkScheme { get; }
      string PassMark { get; }
  }

  public interface IStudent
  {
      string[] TestsTaken { get; }
      void TakeTest(ITestpaper paper, string[] answers);
  }

  public class Testpaper : ITestpaper
  {
      public string Subject { get; }

      public string[] MarkScheme { get; }

      public string PassMark { get; }
      public Testpaper(string subject, string[] markScheme, string passMark)
      {
          Subject = subject;
          MarkScheme = markScheme;
          PassMark = passMark;
      }
  }

  public class Student : IStudent
  {
      List<string> list = new List<string>();
      public string[] TestsTaken { get { return list.Count == 0 ? new string[] { "No tests taken"} : list.ToArray(); } }

      public void TakeTest(ITestpaper paper, string[] answers)
      {
          int percent = Convert.ToInt32((double)100 / (double)answers.Length * (double)paper.MarkScheme.Where(x => answers.Contains(x)).Count());
          if (int.Parse(paper.PassMark.Substring(0, paper.PassMark.Length - 1)) <= percent)
          { list.Add(paper.Subject + ": Passed! " + "(" + percent + "%)"); list.Sort(); }
          else { list.Add(paper.Subject + ": Failed! " + "(" + percent + "%)"); list.Sort(); }
      }
  }