using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.NET.Services.Label
{
    public class LabelClient: ILabelClient
    {
        private readonly TodoistConfiguration _config;

        public LabelClient(TodoistConfiguration config)
        {
            _config = config;
        }
    }
}
