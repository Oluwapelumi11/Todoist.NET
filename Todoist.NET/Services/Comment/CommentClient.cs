using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.NET.Services.Comment
{
    public class CommentClient : ICommentClient
    {
        private readonly TodoistConfiguration _config;

        public CommentClient(TodoistConfiguration config)
        {
            _config = config;
        }
    }
}
