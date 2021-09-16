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

    }
}
