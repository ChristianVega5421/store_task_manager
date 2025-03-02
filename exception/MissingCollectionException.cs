using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager_netcore.exception
{
    [Serializable]
    public class MissingCollectionException : Exception
    {
        public MissingCollectionException() { }

        public MissingCollectionException(string message) : base(message)
        {
        }
    }
}
