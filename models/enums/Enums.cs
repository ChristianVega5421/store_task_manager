using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager_netcore.models.enums
{
    public static class Enums
    {
        public enum TaskStatus
        {
            Select = 0,
            Deleted = -1,
            Completed = 2
        }
    }
}
