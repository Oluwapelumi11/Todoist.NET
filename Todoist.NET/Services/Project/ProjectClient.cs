using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.NET.Services.Project
{
   public class ProjectClient: IProjectClient
    {
        private readonly TodoistConfiguration _config;

        public ProjectClient(TodoistConfiguration config)
        {
            _config = config;
        }
    }
}
