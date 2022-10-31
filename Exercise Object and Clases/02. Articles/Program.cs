using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] inputArgs = input.Split(", ");
            Article article = new Article(inputArgs[0], inputArgs[1], inputArgs[2]);
            for (int i = 0; i <n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split(" ");
                if (cmdArgs[0]=="Edit:")
                {
                    string content = string.Empty;
                    for (int j = 1; j < cmdArgs.Length; j++)
                    {
                        if (j > 1)
                        {
                            content += " " + cmdArgs[j];
                        }
                        else
                        {
                            content += cmdArgs[j];
                        }
                    }
                    article.Edit(content);
                }
                else if (cmdArgs[0]=="ChangeAuthor:")
                {
                    string author = string.Empty;
                    for (int j = 1; j < cmdArgs.Length; j++)
                    {
                        if (j>1)
                        {
                            author +=" "+ cmdArgs[j];
                        }
                        else
                        {
                            author += cmdArgs[j];
                        }

                    }
                    article.ChangeAuthor(author);
                }
                else if (cmdArgs[0]=="Rename:")
                {
                    string title = string.Empty;
                    for (int j = 1; j < cmdArgs.Length; j++)
                    {
                        if (j > 1)
                        {
                            title += " " + cmdArgs[j];
                        }
                        else
                        {
                            title += cmdArgs[j];
                        }
                    }
                    article.Rename(title);
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }
}
