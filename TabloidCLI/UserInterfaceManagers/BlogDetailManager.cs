using System;
using System.Collections.Generic;
using TabloidCLI.Models;
using TabloidCLI.Repositories;

namespace TabloidCLI.UserInterfaceManagers
{
    internal class BlogDetailManager : IUserInterfaceManager
    {
        private IUserInterfaceManager _parentUI;
        private BlogRepository _blogRepository;
        private PostRepository _postRepository;
        private TagRepository _tagRepository;
        private int _blogId;

        public BlogDetailManager(IUserInterfaceManager parentUi, string connectionString, int blogId)
        {
            _parentUI = parentUi;
            _blogRepository = new BlogRepository(connectionString);
            _blogRepository = new BlogRepository(connectionString);
            _tagRepository = new TagRepository(connectionString);
            _blogId = blogId;
        }

        public IUserInterfaceManager Execute()
        {
            Blog blog = _blogRepository.Get(_blogId);
           
            Console.WriteLine($"{blog.Title} Details");
            Console.WriteLine(" 1) View");
            Console.WriteLine(" 2) Add Tag");
            Console.WriteLine(" 3) Remove Tag");
            Console.WriteLine(" 4) View Posts");
            Console.WriteLine(" 0) Return");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    View();
                    return this;
                case "2":
                    return this;
                case "3":
                    return this;
                case "4":
                    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }

        private void View()
        {
            Blog blog = _blogRepository.Get(_blogId);
            Console.WriteLine($"Title: {blog.Title}");
            Console.WriteLine($"URL: {blog.Url}");
            Console.WriteLine();
        }

    }
}
