using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.NET.Services.Task
{
    public class TaskClient: ITaskClient
    {
        private readonly TodoistConfiguration _config;

        public TaskClient(TodoistConfiguration config)
        {
            _config = config;
        }
    }
}
