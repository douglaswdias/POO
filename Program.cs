// See https://aka.ms/new-console-template for more information
using POO.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("The C# Programming Language", "https://docs.microsoft.com/dotnet/csharp/"));
articles.Add(new Article("OOP in C#", "https://docs.microsoft.com/dotnet/csharp/fundamentals/tutorials/oop"));

foreach (var article in articles)
{
  Console.WriteLine(article.Id);
  Console.WriteLine(article.Title);
  Console.WriteLine(article.Url);
}