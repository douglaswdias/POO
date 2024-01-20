using System.Net.Http.Headers;
using POO.ContentContext.Enums;

namespace POO.ContentContext
{
  public class Course : Content
  {
    public Course()
    {
      Modules = new List<Module>();      
    }
    public string? Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EcontentLevel Level { get; set; }
  }
}