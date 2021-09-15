using System;
using System.Collections.Generic;
using System.Text;
using TabloidCLI.Models;
using TabloidCLI.Repositories;

namespace TabloidCLI.UserInterfaceManagers
{
    public class BlogManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        private BlogRepository _blogRepository;
        private string _connectionString;

        public BlogManager(IUserInterfaceManager parentUI, string connectionString)
        {
            _parentUI = parentUI;
            _blogRepository = new BlogRepository(connectionString);
            _connectionString = connectionString;
        }

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Blog Menu");
            Console.WriteLine(" 1) See Blogs");
            Console.WriteLine(" 2) Add Blog");
            Console.WriteLine(" 0) Go Back");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    List();
                    return this;
                case "2":
                    Console.Clear();
                    Add();
                    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }

        private void Add()
        {
            Console.WriteLine("Add new blog");
            Blog blog = new Blog();

            Console.WriteLine("Enter title");
            blog.Title = Console.ReadLine();

            Console.WriteLine("Enter URL");
            blog.Url = Console.ReadLine();

            _blogRepository.Insert(blog);
            Console.Clear();
        }
        private void List()
        {
            List<Blog> blogs = _blogRepository.GetAll();
            foreach (Blog blog in blogs)
            {
                Console.WriteLine(blog);
            }
        }

       /* private Blog Choose(string prompt = null)
        {
            if (prompt == null)
            {
                prompt = "Please choose a Blog:";
            }
        }*/
/*        private void Remove()
        {
            Blog blogToDelete = Choose("");
        }*/
        

    }
}
