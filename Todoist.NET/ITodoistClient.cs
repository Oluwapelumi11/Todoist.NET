using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.NET.Services.Comment;
using Todoist.NET.Services.Label;
using Todoist.NET.Services.Project;
using Todoist.NET.Services.Section;
using Todoist.NET.Services.Task;

namespace Todoist.NET
{
    public interface ITodoistClient
    {
        public ITaskClient Tasks { get; }
        public IProjectClient Projects { get; }
        public ILabelClient Labels { get; }
        public ICommentClient Comments { get; }
        public ISectionClient Sections { get; }
    }
}
