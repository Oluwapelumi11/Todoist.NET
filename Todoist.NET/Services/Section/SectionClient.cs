using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.NET.Services.Section
{
    public class SectionClient : ISectionClient
    {
        private readonly TodoistConfiguration _config;

        public SectionClient(TodoistConfiguration config)
        {
            _config = config;
        }
    }
}
