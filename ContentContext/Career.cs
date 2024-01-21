using System.Runtime.CompilerServices;
namespace POO.ContentContext
{
  public class Career : Content
  {
    public Career(string title, string url) : base(title, url)
    {
      Items = new List<CarrerItem>();
    }
    public IList<CarrerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}