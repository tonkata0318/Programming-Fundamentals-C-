using System;
using System.Collections.Generic;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArgs = input.Split(", ");
                string title=inputArgs[0];
                string content=inputArgs[1];
                string author=inputArgs[2];
                Article article=new Article(title, content, author);
                articles.Add(article);
            }
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
