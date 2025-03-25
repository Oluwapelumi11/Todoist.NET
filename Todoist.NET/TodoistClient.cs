﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.NET.Services;
using Todoist.NET.Services.Comment;
using Todoist.NET.Services.Label;
using Todoist.NET.Services.Project;
using Todoist.NET.Services.Section;
using Todoist.NET.Services.Task;

namespace Todoist.NET
{
    public class TodoistClient : ITodoistClient
    {
        public ITaskClient Tasks { get; }

        public IProjectClient Projects { get; }

        public ILabelClient Labels { get; }

        public ICommentClient Comments { get; }

        public ISectionClient Sections { get; }

        public TodoistClient(HttpClient httpClient, string apiKey)
        {
            var config = new TodoistConfiguration(httpClient, apiKey);
            Tasks = new TaskClient(config);
            Projects = new ProjectClient(config);
            Labels = new LabelClient(config);
            Comments = new CommentClient(config);
            Sections = new SectionClient(config);
        }
    }
}
